namespace Mytra.Service
{
	using Core;
	using Utilize;
	using AutoMapper;
	using FluentValidation;

	public class CandidateEducationService : BusinessObject<CandidateEducation>, ICandidateEducationService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateEducation> Validator;

		public CandidateEducationService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidateEducation> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<CandidateEducation>> InsertAsync(CandidateEducationInsert Model)
		{
			try
			{
				Data = Mapper.Map<CandidateEducation>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<CandidateEducation>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(), "");
				}

				await UnitOfWork.CandidateEducation.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<CandidateEducation>.SuccessResult(Data, "")
					: DataService<CandidateEducation>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<CandidateEducation>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidateEducation>> UpdateAsync(CandidateEducationUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateEducation.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null) return DataService<CandidateEducation>.FailureResult("");

				Data = Collection.SingleOrDefault()!;
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.CandidateEducation.UpdateAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<CandidateEducation>.SuccessResult(Data, "")
					: DataService<CandidateEducation>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<CandidateEducation>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidateEducation>> DeleteAsync(Guid Id)
		{
			try
			{
				Collection = await UnitOfWork.CandidateEducation.SelectAsync(x => x.Id == Id);
				if (Collection.SingleOrDefault() == null) return DataService<CandidateEducation>.FailureResult("");

				Data = Collection.SingleOrDefault()!;
				await UnitOfWork.CandidateEducation.DeleteAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<CandidateEducation>.SuccessResult(Collection.SingleOrDefault()!, "")
					: DataService<CandidateEducation>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<CandidateEducation>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidateEducation>> SelectAsync(CandidateEducationSelect Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateEducation.SelectAsync(x => x.IsActive);
				return DataService<CandidateEducation>.SuccessResult(Collection, "");
			}
			catch (Exception ex)
			{
				return DataService<CandidateEducation>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidateEducation>> SelectSingleAsync(CandidateEducationSelectSingle Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateEducation.SelectAsync(x => x.Id == Model.Id && x.IsActive);
				if (Collection == null) return DataService<CandidateEducation>.FailureResult("");
				return DataService<CandidateEducation>.SuccessResult(Collection.SingleOrDefault()!, "");
			}
			catch (Exception ex)
			{
				return DataService<CandidateEducation>.FailureResult(ex.Message, "");
			}
		}
	}
}