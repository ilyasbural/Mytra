namespace Mytra.Service
{
	using Core;
	using Common;

	public class ManagerService : IManagerService
	{
		public ManagerService()
		{
			
		}

		public async Task<ServiceResponse<ManagerResponse>> InsertAsync(ManagerInsert Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<ManagerResponse>> UpdateAsync(ManagerUpdate Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<ManagerResponse>> DeleteAsync(ManagerDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<ManagerResponse>> SelectAsync(ManagerSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<ManagerResponse>> SelectSingleAsync(ManagerSelectSingle Model)
		{
			throw new NotImplementedException();
		}
	}
}