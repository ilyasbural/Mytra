namespace Mytra.Service
{
	using Core;
	using Common;

	public class JobPostingService : IJobPostingService
	{
		public JobPostingService()
		{
			
		}

		public async Task<ServiceResponse<JobPostingResponse>> InsertAsync(JobPostingInsert Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<JobPostingResponse>> UpdateAsync(JobPostingUpdate Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<JobPostingResponse>> DeleteAsync(JobPostingDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<JobPostingResponse>> SelectAsync(JobPostingSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<JobPostingResponse>> SelectSingleAsync(JobPostingSelectSingle Model)
		{
			throw new NotImplementedException();
		}
	}
}