namespace Mytra.Core
{
    public interface ICandidateSkillsService
    {
		Task<Utilize.DataService<CandidateSkills>> InsertAsync(Utilize.CandidateSkillsInsert Model);
		Task<Utilize.DataService<CandidateSkills>> UpdateAsync(Utilize.CandidateSkillsUpdate Model);
		Task<Utilize.DataService<CandidateSkills>> DeleteAsync(Guid Id);
		Task<Utilize.DataService<CandidateSkills>> SelectAsync(Utilize.CandidateSkillsSelect Model);
		Task<Utilize.DataService<CandidateSkills>> SelectSingleAsync(Utilize.CandidateSkillsSelectSingle Model);
	}
}