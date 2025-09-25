namespace Mytra.Core
{
    public interface ICandidateContactService
    {
		Task<Utilize.DataService<CandidateContact>> InsertAsync(Utilize.CandidateContactInsert Model);
		Task<Utilize.DataService<CandidateContact>> UpdateAsync(Utilize.CandidateContactUpdate Model);
		Task<Utilize.DataService<CandidateContact>> DeleteAsync(Guid Id);
		Task<Utilize.DataService<CandidateContact>> SelectAsync(Utilize.CandidateContactSelect Model);
		Task<Utilize.DataService<CandidateContact>> SelectSingleAsync(Utilize.CandidateContactSelectSingle Model);
	}
}