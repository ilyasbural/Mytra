namespace Mytra.Service
{
	using Core;
	using Utilize;
	using AutoMapper;
	using FluentValidation;

	public class JobPostingDetailService : BusinessObject<JobPostingDetail>, IJobPostingDetailService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<JobPostingDetail> Validator;

		public JobPostingDetailService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<JobPostingDetail> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<JobPostingDetail>> InsertAsync(JobPostingDetailInsert Model)
		{
			try
			{
				Data = Mapper.Map<JobPostingDetail>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<JobPostingDetail>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(), "");
				}

				await UnitOfWork.JobPostingDetail.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<JobPostingDetail>.SuccessResult(Data, "")
					: DataService<JobPostingDetail>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<JobPostingDetail>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<JobPostingDetail>> UpdateAsync(JobPostingDetailUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.JobPostingDetail.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null) return DataService<JobPostingDetail>.FailureResult("");

				Data = Collection.SingleOrDefault()!;
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.JobPostingDetail.UpdateAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<JobPostingDetail>.SuccessResult(Data, "")
					: DataService<JobPostingDetail>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<JobPostingDetail>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<JobPostingDetail>> DeleteAsync(Guid Id)
		{
			try
			{
				Collection = await UnitOfWork.JobPostingDetail.SelectAsync(x => x.Id == Id);
				if (Collection.SingleOrDefault() == null) return DataService<JobPostingDetail>.FailureResult("");

				Data = Collection.SingleOrDefault()!;
				await UnitOfWork.JobPostingDetail.DeleteAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<JobPostingDetail>.SuccessResult(Collection.SingleOrDefault()!, "")
					: DataService<JobPostingDetail>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<JobPostingDetail>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<JobPostingDetail>> SelectAsync(JobPostingDetailSelect Model)
		{
			try
			{
				Collection = await UnitOfWork.JobPostingDetail.SelectAsync(x => x.IsActive);
				return DataService<JobPostingDetail>.SuccessResult(Collection, "");
			}
			catch (Exception ex)
			{
				return DataService<JobPostingDetail>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<JobPostingDetail>> SelectSingleAsync(JobPostingDetailSelectSingle Model)
		{
			try
			{
				Collection = await UnitOfWork.JobPostingDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive);
				if (Collection == null) return DataService<JobPostingDetail>.FailureResult("");
				return DataService<JobPostingDetail>.SuccessResult(Collection.SingleOrDefault()!, "");
			}
			catch (Exception ex)
			{
				return DataService<JobPostingDetail>.FailureResult(ex.Message, "");
			}
		}
	}
}