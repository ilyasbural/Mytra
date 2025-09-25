namespace Mytra.Service
{
	using Core;
	using Utilize;
	using AutoMapper;
	using FluentValidation;

	public class CandidateDetailService : BusinessObject<CandidateDetail>, ICandidateDetailService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateDetail> Validator;

		public CandidateDetailService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidateDetail> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<CandidateDetail>> InsertAsync(CandidateDetailInsert Model)
		{
			try
			{
				Data = Mapper.Map<CandidateDetail>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<CandidateDetail>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.CandidateDetail.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<CandidateDetail>.SuccessResult(Data, "Record has been success")
					: DataService<CandidateDetail>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<CandidateDetail>.FailureResult(ex.Message, "some error");
			}
		}

		public async Task<DataService<CandidateDetail>> UpdateAsync(CandidateDetailUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateDetail.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null) return DataService<CandidateDetail>.FailureResult("Kayıt bulunamadı");

				Data = Collection.SingleOrDefault()!;
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.CandidateDetail.UpdateAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<CandidateDetail>.SuccessResult(Data, "Kayıt güncellendi")
					: DataService<CandidateDetail>.FailureResult("Kayıt güncellenemedi");
			}
			catch (Exception ex)
			{
				return DataService<CandidateDetail>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		public async Task<DataService<CandidateDetail>> DeleteAsync(Guid Id)
		{
			try
			{
				Collection = await UnitOfWork.CandidateDetail.SelectAsync(x => x.Id == Id);
				if (Collection.SingleOrDefault() == null) return DataService<CandidateDetail>.FailureResult("Kayıt bulunamadı");

				Data = Collection.SingleOrDefault()!;
				await UnitOfWork.CandidateDetail.DeleteAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<CandidateDetail>.SuccessResult(Collection.SingleOrDefault()!, "Kayıt silindi")
					: DataService<CandidateDetail>.FailureResult("Kayıt silinemedi");
			}
			catch (Exception ex)
			{
				return DataService<CandidateDetail>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		public async Task<DataService<CandidateDetail>> SelectAsync(CandidateDetailSelect Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateDetail.SelectAsync(x => x.IsActive);
				return DataService<CandidateDetail>.SuccessResult(Collection, "Kayıtlar listelendi");
			}
			catch (Exception ex)
			{
				return DataService<CandidateDetail>.FailureResult(ex.Message, "Listeleme hatası");
			}
		}

		public async Task<DataService<CandidateDetail>> SelectSingleAsync(CandidateDetailSelectSingle Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive);
				if (Collection == null) return DataService<CandidateDetail>.FailureResult("Kayıt bulunamadı");
				return DataService<CandidateDetail>.SuccessResult(Collection.SingleOrDefault()!, "Kayıt bulundu");
			}
			catch (Exception ex)
			{
				return DataService<CandidateDetail>.FailureResult(ex.Message, "Sorgu hatası");
			}
		}
	}
}