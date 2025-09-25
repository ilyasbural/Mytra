namespace Mytra.Service
{
	using Core;
	using Utilize;
	using AutoMapper;
	using FluentValidation;

	public class CandidateCertificateService : BusinessObject<CandidateCertificate>, ICandidateCertificateService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateCertificate> Validator;

		public CandidateCertificateService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidateCertificate> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<CandidateCertificate>> InsertAsync(CandidateCertificateInsert Model)
		{
			try
			{
				Data = Mapper.Map<CandidateCertificate>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<CandidateCertificate>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.CandidateCertificate.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<CandidateCertificate>.SuccessResult(Data, "Record has been success")
					: DataService<CandidateCertificate>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<CandidateCertificate>.FailureResult(ex.Message, "some error");
			}
		}

		public async Task<DataService<CandidateCertificate>> UpdateAsync(CandidateCertificateUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateCertificate.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null) return DataService<CandidateCertificate>.FailureResult("Kayıt bulunamadı");

				Data = Collection.SingleOrDefault()!;
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.CandidateCertificate.UpdateAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<CandidateCertificate>.SuccessResult(Data, "Kayıt güncellendi")
					: DataService<CandidateCertificate>.FailureResult("Kayıt güncellenemedi");
			}
			catch (Exception ex)
			{
				return DataService<CandidateCertificate>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		public async Task<DataService<CandidateCertificate>> DeleteAsync(Guid Id)
		{
			try
			{
				Collection = await UnitOfWork.CandidateCertificate.SelectAsync(x => x.Id == Id);
				if (Collection.SingleOrDefault() == null) return DataService<CandidateCertificate>.FailureResult("Kayıt bulunamadı");

				Data = Collection.SingleOrDefault()!;
				await UnitOfWork.CandidateCertificate.DeleteAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<CandidateCertificate>.SuccessResult(Collection.SingleOrDefault()!, "Kayıt silindi")
					: DataService<CandidateCertificate>.FailureResult("Kayıt silinemedi");
			}
			catch (Exception ex)
			{
				return DataService<CandidateCertificate>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		public async Task<DataService<CandidateCertificate>> SelectAsync(CandidateCertificateSelect Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateCertificate.SelectAsync(x => x.IsActive);
				return DataService<CandidateCertificate>.SuccessResult(Collection, "Kayıtlar listelendi");
			}
			catch (Exception ex)
			{
				return DataService<CandidateCertificate>.FailureResult(ex.Message, "Listeleme hatası");
			}
		}

		public async Task<DataService<CandidateCertificate>> SelectSingleAsync(CandidateCertificateSelectSingle Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateCertificate.SelectAsync(x => x.Id == Model.Id && x.IsActive);
				if (Collection == null) return DataService<CandidateCertificate>.FailureResult("Kayıt bulunamadı");
				return DataService<CandidateCertificate>.SuccessResult(Collection.SingleOrDefault()!, "Kayıt bulundu");
			}
			catch (Exception ex)
			{
				return DataService<CandidateCertificate>.FailureResult(ex.Message, "Sorgu hatası");
			}
		}
	}
}