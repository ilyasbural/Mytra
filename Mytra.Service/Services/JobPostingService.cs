namespace Mytra.Service
{
	using Core;
	using Utilize;
	using AutoMapper;
	using FluentValidation;

	public class JobPostingService : BusinessObject<JobPosting>, IJobPostingService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<JobPosting> Validator;

		public JobPostingService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<JobPosting> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<JobPosting>> InsertAsync(JobPostingInsert Model)
		{
			try
			{
				Data = Mapper.Map<JobPosting>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<JobPosting>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(), "");
				}

				await UnitOfWork.JobPosting.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<JobPosting>.SuccessResult(Data, "")
					: DataService<JobPosting>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<JobPosting>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<JobPosting>> UpdateAsync(JobPostingUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.JobPosting.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null) return DataService<JobPosting>.FailureResult("");

				Data = Collection.SingleOrDefault()!;
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.JobPosting.UpdateAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<JobPosting>.SuccessResult(Data, "")
					: DataService<JobPosting>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<JobPosting>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<JobPosting>> DeleteAsync(Guid Id)
		{
			try
			{
				Collection = await UnitOfWork.JobPosting.SelectAsync(x => x.Id == Id);
				if (Collection.SingleOrDefault() == null) return DataService<JobPosting>.FailureResult("");

				Data = Collection.SingleOrDefault()!;
				await UnitOfWork.JobPosting.DeleteAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<JobPosting>.SuccessResult(Collection.SingleOrDefault()!, "")
					: DataService<JobPosting>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<JobPosting>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<JobPosting>> SelectAsync(JobPostingSelect Model)
		{
			try
			{
				Collection = await UnitOfWork.JobPosting.SelectAsync(x => x.IsActive);
				return DataService<JobPosting>.SuccessResult(Collection, "");
			}
			catch (Exception ex)
			{
				return DataService<JobPosting>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<JobPosting>> SelectSingleAsync(JobPostingSelectSingle Model)
		{
			try
			{
				Collection = await UnitOfWork.JobPosting.SelectAsync(x => x.Id == Model.Id && x.IsActive);
				if (Collection == null) return DataService<JobPosting>.FailureResult("");
				return DataService<JobPosting>.SuccessResult(Collection.SingleOrDefault()!, "");
			}
			catch (Exception ex)
			{
				return DataService<JobPosting>.FailureResult(ex.Message, "");
			}
		}
	}
}