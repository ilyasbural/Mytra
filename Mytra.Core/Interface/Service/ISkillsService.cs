namespace Mytra.Core
{
    public interface ISkillsService
    {
		Task<Common.DataService<Skills>> InsertAsync(Common.SkillsInsert Model);
		Task<Common.DataService<Skills>> UpdateAsync(Common.SkillsUpdate Model);
		Task<Common.DataService<Skills>> DeleteAsync(Guid Id);
		Task<Common.DataService<Skills>> SelectAsync(Common.SkillsSelect Model);
		Task<Common.DataService<Skills>> SelectSingleAsync(Common.SkillsSelectSingle Model);
	}
}