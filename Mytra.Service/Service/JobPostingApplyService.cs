namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class JobPostingApplyService : BusinessObject<JobPostingApply>, IJobPostingApplyService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<JobPostingApply> Validator;

		public JobPostingApplyService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<JobPostingApply> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<ServiceResponse<JobPostingApplyResponse>> InsertAsync(JobPostingApplyInsert Model)
		{
			Data = Mapper.Map<JobPostingApply>(Model);
			Data.Id = Guid.NewGuid();
			Data.RegisterDate = DateTime.Now;
			Data.UpdateDate = DateTime.Now;
			Data.IsActive = true;

			Validator.ValidateAndThrow<JobPostingApply>(Data);
			await UnitOfWork.JobPostingApply.InsertAsync(Data);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<JobPostingApplyResponse>
			{
				Success = Success,
				ResponseData = Mapper.Map<JobPostingApplyResponse>(Data)
			};
		}

		public async Task<ServiceResponse<JobPostingApplyResponse>> UpdateAsync(JobPostingApplyUpdate Model)
		{
			Collection = await UnitOfWork.JobPostingApply.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			JobPostingApply JobPostingApply = Collection.SingleOrDefault()!;
			JobPostingApply.Name = Model.Name;
			await UnitOfWork.JobPostingApply.UpdateAsync(JobPostingApply);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<JobPostingApplyResponse>
			{
				Success = Success,
				ResponseData = Mapper.Map<JobPostingApplyResponse>(JobPostingApply)
			};
		}

		public async Task<ServiceResponse<JobPostingApplyResponse>> DeleteAsync(JobPostingApplyDelete Model)
		{
			Collection = await UnitOfWork.JobPostingApply.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			JobPostingApply JobPostingApply = Collection.SingleOrDefault()!;
			await UnitOfWork.JobPostingApply.DeleteAsync(JobPostingApply);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<JobPostingApplyResponse>
			{
				Success = Success,
				ResponseData = Mapper.Map<JobPostingApplyResponse>(JobPostingApply)
			};
		}

		public async Task<ServiceResponse<JobPostingApplyResponse>> SelectAsync(JobPostingApplySelect Model)
		{
			return new ServiceResponse<JobPostingApplyResponse>
			{
				ResponseDataSource = Mapper.Map<List<JobPostingApplyResponse>>
				(await UnitOfWork.JobPostingApply.SelectAsync(x => x.IsActive == true))
			};
		}

		public async Task<ServiceResponse<JobPostingApplyResponse>> SelectSingleAsync(JobPostingApplySelectSingle Model)
		{
			return new ServiceResponse<JobPostingApplyResponse>
			{
				ResponseDataSource = Mapper.Map<List<JobPostingApplyResponse>>
				(await UnitOfWork.JobPostingApply.SelectAsync(x => x.Id == Model.Id && x.IsActive == true))
			};
		}
	}
}