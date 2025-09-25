namespace Mytra.Core
{
    public interface ISkillsService
    {
		Task<Utilize.DataService<Skills>> InsertAsync(Utilize.SkillsInsert Model);
		Task<Utilize.DataService<Skills>> UpdateAsync(Utilize.SkillsUpdate Model);
		Task<Utilize.DataService<Skills>> DeleteAsync(Guid Id);
		Task<Utilize.DataService<Skills>> SelectAsync(Utilize.SkillsSelect Model);
		Task<Utilize.DataService<Skills>> SelectSingleAsync(Utilize.SkillsSelectSingle Model);
	}
}