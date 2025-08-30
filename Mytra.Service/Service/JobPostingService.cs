namespace Mytra.Service
{
	using Core;
	using Common;
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

		public async Task<ServiceResponse<JobPostingResponse>> InsertAsync(JobPostingInsert Model)
		{
			Data = Mapper.Map<JobPosting>(Model);
			Data.Id = Guid.NewGuid();
			Data.RegisterDate = DateTime.Now;
			Data.UpdateDate = DateTime.Now;
			Data.IsActive = true;

			Validator.ValidateAndThrow<JobPosting>(Data);
			await UnitOfWork.JobPosting.InsertAsync(Data);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<JobPostingResponse>
			{
				Success = Success,
				ResponseData = Mapper.Map<JobPostingResponse>(Data)
			};
		}

		public async Task<ServiceResponse<JobPostingResponse>> UpdateAsync(JobPostingUpdate Model)
		{
			Collection = await UnitOfWork.JobPosting.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			JobPosting JobPosting = Collection.SingleOrDefault()!;
			JobPosting.Name = Model.Name;
			await UnitOfWork.JobPosting.UpdateAsync(JobPosting);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<JobPostingResponse>
			{
				Success = Success,
				ResponseData = Mapper.Map<JobPostingResponse>(JobPosting)
			};
		}

		public async Task<ServiceResponse<JobPostingResponse>> DeleteAsync(JobPostingDelete Model)
		{
			Collection = await UnitOfWork.JobPosting.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			JobPosting JobPosting = Collection.SingleOrDefault()!;
			await UnitOfWork.JobPosting.DeleteAsync(JobPosting);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<JobPostingResponse>
			{
				Success = Success,
				ResponseData = Mapper.Map<JobPostingResponse>(JobPosting)
			};
		}

		public async Task<ServiceResponse<JobPostingResponse>> SelectAsync(JobPostingSelect Model)
		{
			return new ServiceResponse<JobPostingResponse>
			{
				ResponseDataSource = Mapper.Map<List<JobPostingResponse>>
				(await UnitOfWork.JobPosting.SelectAsync(x => x.IsActive == true))
			};
		}

		public async Task<ServiceResponse<JobPostingResponse>> SelectSingleAsync(JobPostingSelectSingle Model)
		{
			return new ServiceResponse<JobPostingResponse>
			{
				ResponseDataSource = Mapper.Map<List<JobPostingResponse>>
				(await UnitOfWork.JobPosting.SelectAsync(x => x.IsActive == true))
			};
		}
	}
}