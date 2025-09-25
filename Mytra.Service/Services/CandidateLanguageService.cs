namespace Mytra.Service
{
	using Core;
	using Utilize;
	using AutoMapper;
	using FluentValidation;

	public class CandidateLanguageService : BusinessObject<CandidateLanguage>, ICandidateLanguageService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateLanguage> Validator;

		public CandidateLanguageService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidateLanguage> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<CandidateLanguage>> InsertAsync(CandidateLanguageInsert Model)
		{
			try
			{
				Data = Mapper.Map<CandidateLanguage>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<CandidateLanguage>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.CandidateLanguage.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<CandidateLanguage>.SuccessResult(Data, "Record has been success")
					: DataService<CandidateLanguage>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<CandidateLanguage>.FailureResult(ex.Message, "some error");
			}
		}

		public async Task<DataService<CandidateLanguage>> UpdateAsync(CandidateLanguageUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateLanguage.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null) return DataService<CandidateLanguage>.FailureResult("Kayıt bulunamadı");

				Data = Collection.SingleOrDefault()!;
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.CandidateLanguage.UpdateAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<CandidateLanguage>.SuccessResult(Data, "Kayıt güncellendi")
					: DataService<CandidateLanguage>.FailureResult("Kayıt güncellenemedi");
			}
			catch (Exception ex)
			{
				return DataService<CandidateLanguage>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		public async Task<DataService<CandidateLanguage>> DeleteAsync(Guid Id)
		{
			try
			{
				Collection = await UnitOfWork.CandidateLanguage.SelectAsync(x => x.Id == Id);
				if (Collection.SingleOrDefault() == null) return DataService<CandidateLanguage>.FailureResult("Kayıt bulunamadı");

				Data = Collection.SingleOrDefault()!;
				await UnitOfWork.CandidateLanguage.DeleteAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<CandidateLanguage>.SuccessResult(Collection.SingleOrDefault()!, "Kayıt silindi")
					: DataService<CandidateLanguage>.FailureResult("Kayıt silinemedi");
			}
			catch (Exception ex)
			{
				return DataService<CandidateLanguage>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		public async Task<DataService<CandidateLanguage>> SelectAsync(CandidateLanguageSelect Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateLanguage.SelectAsync(x => x.IsActive);
				return DataService<CandidateLanguage>.SuccessResult(Collection, "Kayıtlar listelendi");
			}
			catch (Exception ex)
			{
				return DataService<CandidateLanguage>.FailureResult(ex.Message, "Listeleme hatası");
			}
		}

		public async Task<DataService<CandidateLanguage>> SelectSingleAsync(CandidateLanguageSelectSingle Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateLanguage.SelectAsync(x => x.Id == Model.Id && x.IsActive);
				if (Collection == null) return DataService<CandidateLanguage>.FailureResult("Kayıt bulunamadı");
				return DataService<CandidateLanguage>.SuccessResult(Collection.SingleOrDefault()!, "Kayıt bulundu");
			}
			catch (Exception ex)
			{
				return DataService<CandidateLanguage>.FailureResult(ex.Message, "Sorgu hatası");
			}
		}
	}
}