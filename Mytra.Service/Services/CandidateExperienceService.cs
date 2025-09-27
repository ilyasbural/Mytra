namespace Mytra.Service
{
	using Core;
	using Utilize;
	using AutoMapper;
	using FluentValidation;

	public class CandidateExperienceService : BusinessObject<CandidateExperience>, ICandidateExperienceService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateExperience> Validator;

		public CandidateExperienceService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidateExperience> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<CandidateExperience>> InsertAsync(CandidateExperienceInsert Model)
		{
			try
			{
				Data = Mapper.Map<CandidateExperience>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<CandidateExperience>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.CandidateExperience.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<CandidateExperience>.SuccessResult(Data, "")
					: DataService<CandidateExperience>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<CandidateExperience>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidateExperience>> UpdateAsync(CandidateExperienceUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateExperience.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null) return DataService<CandidateExperience>.FailureResult("");

				Data = Collection.SingleOrDefault()!;
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.CandidateExperience.UpdateAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<CandidateExperience>.SuccessResult(Data, "")
					: DataService<CandidateExperience>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<CandidateExperience>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidateExperience>> DeleteAsync(Guid Id)
		{
			try
			{
				Collection = await UnitOfWork.CandidateExperience.SelectAsync(x => x.Id == Id);
				if (Collection.SingleOrDefault() == null) return DataService<CandidateExperience>.FailureResult("");

				Data = Collection.SingleOrDefault()!;
				await UnitOfWork.CandidateExperience.DeleteAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<CandidateExperience>.SuccessResult(Collection.SingleOrDefault()!, "")
					: DataService<CandidateExperience>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<CandidateExperience>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidateExperience>> SelectAsync(CandidateExperienceSelect Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateExperience.SelectAsync(x => x.IsActive);
				return DataService<CandidateExperience>.SuccessResult(Collection, "");
			}
			catch (Exception ex)
			{
				return DataService<CandidateExperience>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidateExperience>> SelectSingleAsync(CandidateExperienceSelectSingle Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateExperience.SelectAsync(x => x.Id == Model.Id && x.IsActive);
				if (Collection == null) return DataService<CandidateExperience>.FailureResult("");
				return DataService<CandidateExperience>.SuccessResult(Collection.SingleOrDefault()!, "");
			}
			catch (Exception ex)
			{
				return DataService<CandidateExperience>.FailureResult(ex.Message, "");
			}
		}
	}
}