namespace Mytra.Service
{
	using Core;
	using Utilize;
	using AutoMapper;
	using FluentValidation;

	public class CandidateContactService : BusinessObject<CandidateContact>, ICandidateContactService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateContact> Validator;

		public CandidateContactService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidateContact> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<CandidateContact>> InsertAsync(CandidateContactInsert Model)
		{
			try
			{
				Data = Mapper.Map<CandidateContact>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<CandidateContact>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.CandidateContact.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<CandidateContact>.SuccessResult(Data, "Record has been success")
					: DataService<CandidateContact>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<CandidateContact>.FailureResult(ex.Message, "some error");
			}
		}

		public async Task<DataService<CandidateContact>> UpdateAsync(CandidateContactUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateContact.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null) return DataService<CandidateContact>.FailureResult("Kayıt bulunamadı");

				Data = Collection.SingleOrDefault()!;
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.CandidateContact.UpdateAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<CandidateContact>.SuccessResult(Data, "Kayıt güncellendi")
					: DataService<CandidateContact>.FailureResult("Kayıt güncellenemedi");
			}
			catch (Exception ex)
			{
				return DataService<CandidateContact>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		public async Task<DataService<CandidateContact>> DeleteAsync(Guid Id)
		{
			try
			{
				Collection = await UnitOfWork.CandidateContact.SelectAsync(x => x.Id == Id);
				if (Collection.SingleOrDefault() == null) return DataService<CandidateContact>.FailureResult("Kayıt bulunamadı");

				Data = Collection.SingleOrDefault()!;
				await UnitOfWork.CandidateContact.DeleteAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<CandidateContact>.SuccessResult(Collection.SingleOrDefault()!, "Kayıt silindi")
					: DataService<CandidateContact>.FailureResult("Kayıt silinemedi");
			}
			catch (Exception ex)
			{
				return DataService<CandidateContact>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		public async Task<DataService<CandidateContact>> SelectAsync(CandidateContactSelect Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateContact.SelectAsync(x => x.IsActive);
				return DataService<CandidateContact>.SuccessResult(Collection, "Kayıtlar listelendi");
			}
			catch (Exception ex)
			{
				return DataService<CandidateContact>.FailureResult(ex.Message, "Listeleme hatası");
			}
		}

		public async Task<DataService<CandidateContact>> SelectSingleAsync(CandidateContactSelectSingle Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateContact.SelectAsync(x => x.Id == Model.Id && x.IsActive);
				if (Collection == null) return DataService<CandidateContact>.FailureResult("Kayıt bulunamadı");
				return DataService<CandidateContact>.SuccessResult(Collection.SingleOrDefault()!, "Kayıt bulundu");
			}
			catch (Exception ex)
			{
				return DataService<CandidateContact>.FailureResult(ex.Message, "Sorgu hatası");
			}
		}
	}
}