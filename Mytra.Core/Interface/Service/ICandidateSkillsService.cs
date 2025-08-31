namespace Mytra.Core
{
    public interface ICandidateSkillsService
    {
		Task<Common.DataService<CandidateSkills>> InsertAsync(Common.CandidateSkillsInsert Model);
		Task<Common.DataService<CandidateSkills>> UpdateAsync(Common.CandidateSkillsUpdate Model);
		Task<Common.DataService<CandidateSkills>> DeleteAsync(Common.CandidateSkillsDelete Model);
		Task<Common.DataService<CandidateSkills>> SelectAsync(Common.CandidateSkillsSelect Model);
		Task<Common.DataService<CandidateSkills>> SelectSingleAsync(Common.CandidateSkillsSelectSingle Model);
	}
}