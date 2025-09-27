namespace Mytra.Service
{
	using Core;
	using Utilize;
	using AutoMapper;
	using FluentValidation;

	public class CandidateSkillsService : BusinessObject<CandidateSkills>, ICandidateSkillsService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateSkills> Validator;

		public CandidateSkillsService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidateSkills> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<CandidateSkills>> InsertAsync(CandidateSkillsInsert Model)
		{
			try
			{
				Data = Mapper.Map<CandidateSkills>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<CandidateSkills>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(), "");
				}

				await UnitOfWork.CandidateSkills.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<CandidateSkills>.SuccessResult(Data, "")
					: DataService<CandidateSkills>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<CandidateSkills>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidateSkills>> UpdateAsync(CandidateSkillsUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateSkills.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null) return DataService<CandidateSkills>.FailureResult("");

				Data = Collection.SingleOrDefault()!;
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.CandidateSkills.UpdateAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<CandidateSkills>.SuccessResult(Data, "")
					: DataService<CandidateSkills>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<CandidateSkills>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidateSkills>> DeleteAsync(Guid Id)
		{
			try
			{
				Collection = await UnitOfWork.CandidateSkills.SelectAsync(x => x.Id == Id);
				if (Collection.SingleOrDefault() == null) return DataService<CandidateSkills>.FailureResult("");

				Data = Collection.SingleOrDefault()!;
				await UnitOfWork.CandidateSkills.DeleteAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<CandidateSkills>.SuccessResult(Collection.SingleOrDefault()!, "")
					: DataService<CandidateSkills>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<CandidateSkills>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidateSkills>> SelectAsync(CandidateSkillsSelect Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateSkills.SelectAsync(x => x.IsActive);
				return DataService<CandidateSkills>.SuccessResult(Collection, "");
			}
			catch (Exception ex)
			{
				return DataService<CandidateSkills>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidateSkills>> SelectSingleAsync(CandidateSkillsSelectSingle Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateSkills.SelectAsync(x => x.Id == Model.Id && x.IsActive);
				if (Collection == null) return DataService<CandidateSkills>.FailureResult("");
				return DataService<CandidateSkills>.SuccessResult(Collection.SingleOrDefault()!, "");
			}
			catch (Exception ex)
			{
				return DataService<CandidateSkills>.FailureResult(ex.Message, "");
			}
		}
	}
}