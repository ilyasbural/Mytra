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
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(), "");
				}

				await UnitOfWork.Language.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<Language>.SuccessResult(Data, "")
					: DataService<Language>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<Language>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<Language>> UpdateAsync(LanguageUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.Language.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null) return DataService<Language>.FailureResult("");

				Data = Collection.SingleOrDefault()!;
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.Language.UpdateAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<Language>.SuccessResult(Data, "")
					: DataService<Language>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<Language>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<Language>> DeleteAsync(Guid Id)
		{
			try
			{
				Collection = await UnitOfWork.Language.SelectAsync(x => x.Id == Id);
				if (Collection.SingleOrDefault() == null) return DataService<Language>.FailureResult("");

				await UnitOfWork.Language.DeleteAsync(Collection.SingleOrDefault()!);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<Language>.SuccessResult(Collection.SingleOrDefault()!, "")
					: DataService<Language>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<Language>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<Language>> SelectAsync(LanguageSelect Model)
		{
			try
			{
				Collection = await UnitOfWork.Language.SelectAsync(x => x.IsActive);
				return DataService<Language>.SuccessResult(Collection, "");
			}
			catch (Exception ex)
			{
				return DataService<Language>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<Language>> SelectSingleAsync(LanguageSelectSingle Model)
		{
			try
			{
				Collection = await UnitOfWork.Language.SelectAsync(x => x.Id == Model.Id && x.IsActive);
				if (Collection == null) return DataService<Language>.FailureResult("");
				return DataService<Language>.SuccessResult(Collection.SingleOrDefault()!, "");
			}
			catch (Exception ex)
			{
				return DataService<Language>.FailureResult(ex.Message, "");
			}
		}
	}
}