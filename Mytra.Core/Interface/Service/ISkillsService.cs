namespace Mytra.Core
{
    public interface ISkillsService
    {
		Task<Common.DataService<Skills>> InsertAsync(Common.SkillsInsert Model);
		//Task<Common.ServiceResponse<Common.SkillsResponse>> UpdateAsync(Common.SkillsUpdate Model);
		//Task<Common.ServiceResponse<Common.SkillsResponse>> DeleteAsync(Common.SkillsDelete Model);
		//Task<Common.ServiceResponse<Common.SkillsResponse>> SelectAsync(Common.SkillsSelect Model);
		//Task<Common.ServiceResponse<Common.SkillsResponse>> SelectSingleAsync(Common.SkillsSelectSingle Model);
	}
}