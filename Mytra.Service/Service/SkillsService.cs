namespace Mytra.Service
{
	using Core;
	using Common;

	public class SkillsService : ISkillsService
	{
		public SkillsService()
		{
			
		}

		public Task<ServiceResponse<SkillsResponse>> InsertAsync(SkillsInsert Model)
		{
			throw new NotImplementedException();
		}

		public Task<ServiceResponse<SkillsResponse>> UpdateAsync(SkillsUpdate Model)
		{
			throw new NotImplementedException();
		}

		public Task<ServiceResponse<SkillsResponse>> DeleteAsync(SkillsDelete Model)
		{
			throw new NotImplementedException();
		}

		public Task<ServiceResponse<SkillsResponse>> SelectAsync(SkillsSelect Model)
		{
			throw new NotImplementedException();
		}

		public Task<ServiceResponse<SkillsResponse>> SelectSingleAsync(SkillsSelectSingle Model)
		{
			throw new NotImplementedException();
		}
	}
}