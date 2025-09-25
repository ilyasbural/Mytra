namespace Mytra.Service
{
	using Core;
	using Utilize;
	using AutoMapper;
	using FluentValidation;

	public class LanguageService : BusinessObject<Language>, ILanguageService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<Language> Validator;

		public LanguageService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Language> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<Language>> InsertAsync(LanguageInsert Model)
		{
			try
			{
				Data = Mapper.Map<Language>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<Language>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.Language.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<Language>.SuccessResult(Data, "Record has been success")
					: DataService<Language>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<Language>.FailureResult(ex.Message, "some error");
			}
		}

		public async Task<DataService<Language>> UpdateAsync(LanguageUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.Language.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null) return DataService<Language>.FailureResult("Kayıt bulunamadı");

				Data = Collection.SingleOrDefault()!;
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.Language.UpdateAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<Language>.SuccessResult(Data, "Kayıt güncellendi")
					: DataService<Language>.FailureResult("Kayıt güncellenemedi");
			}
			catch (Exception ex)
			{
				return DataService<Language>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		public async Task<DataService<Language>> DeleteAsync(Guid Id)
		{
			try
			{
				Collection = await UnitOfWork.Language.SelectAsync(x => x.Id == Id);
				if (Collection.SingleOrDefault() == null) return DataService<Language>.FailureResult("Kayıt bulunamadı");

				await UnitOfWork.Language.DeleteAsync(Collection.SingleOrDefault()!);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<Language>.SuccessResult(Collection.SingleOrDefault()!, "Kayıt silindi")
					: DataService<Language>.FailureResult("Kayıt silinemedi");
			}
			catch (Exception ex)
			{
				return DataService<Language>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		public async Task<DataService<Language>> SelectAsync(LanguageSelect Model)
		{
			try
			{
				Collection = await UnitOfWork.Language.SelectAsync(x => x.IsActive);
				return DataService<Language>.SuccessResult(Collection, "Kayıtlar listelendi");
			}
			catch (Exception ex)
			{
				return DataService<Language>.FailureResult(ex.Message, "Listeleme hatası");
			}
		}

		public async Task<DataService<Language>> SelectSingleAsync(LanguageSelectSingle Model)
		{
			try
			{
				Collection = await UnitOfWork.Language.SelectAsync(x => x.Id == Model.Id && x.IsActive);
				if (Collection == null) return DataService<Language>.FailureResult("Kayıt bulunamadı");
				return DataService<Language>.SuccessResult(Collection.SingleOrDefault()!, "Kayıt bulundu");
			}
			catch (Exception ex)
			{
				return DataService<Language>.FailureResult(ex.Message, "Sorgu hatası");
			}
		}
	}
}