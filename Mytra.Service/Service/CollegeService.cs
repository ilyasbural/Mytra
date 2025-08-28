namespace Mytra.Service
{
	using Core;
	using Common;

	public class CollegeService : ICollegeService
	{
		public CollegeService()
		{
			
		}

		public async Task<ServiceResponse<CollegeResponse>> InsertAsync(CollegeInsert Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CollegeResponse>> UpdateAsync(CollegeUpdate Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CollegeResponse>> DeleteAsync(CollegeDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CollegeResponse>> SelectAsync(CollegeSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CollegeResponse>> SelectSingleAsync(CollegeSelectSingle Model)
		{
			throw new NotImplementedException();
		}
	}
}