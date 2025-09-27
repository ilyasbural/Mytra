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
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(), "");
				}

				await UnitOfWork.CandidateLanguage.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<CandidateLanguage>.SuccessResult(Data, "")
					: DataService<CandidateLanguage>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<CandidateLanguage>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidateLanguage>> UpdateAsync(CandidateLanguageUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateLanguage.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null) return DataService<CandidateLanguage>.FailureResult("");

				Data = Collection.SingleOrDefault()!;
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.CandidateLanguage.UpdateAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<CandidateLanguage>.SuccessResult(Data, "")
					: DataService<CandidateLanguage>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<CandidateLanguage>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidateLanguage>> DeleteAsync(Guid Id)
		{
			try
			{
				Collection = await UnitOfWork.CandidateLanguage.SelectAsync(x => x.Id == Id);
				if (Collection.SingleOrDefault() == null) return DataService<CandidateLanguage>.FailureResult("");

				Data = Collection.SingleOrDefault()!;
				await UnitOfWork.CandidateLanguage.DeleteAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<CandidateLanguage>.SuccessResult(Collection.SingleOrDefault()!, "")
					: DataService<CandidateLanguage>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<CandidateLanguage>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidateLanguage>> SelectAsync(CandidateLanguageSelect Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateLanguage.SelectAsync(x => x.IsActive);
				return DataService<CandidateLanguage>.SuccessResult(Collection, "");
			}
			catch (Exception ex)
			{
				return DataService<CandidateLanguage>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidateLanguage>> SelectSingleAsync(CandidateLanguageSelectSingle Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateLanguage.SelectAsync(x => x.Id == Model.Id && x.IsActive);
				if (Collection == null) return DataService<CandidateLanguage>.FailureResult("");
				return DataService<CandidateLanguage>.SuccessResult(Collection.SingleOrDefault()!, "");
			}
			catch (Exception ex)
			{
				return DataService<CandidateLanguage>.FailureResult(ex.Message, "");
			}
		}
	}
}