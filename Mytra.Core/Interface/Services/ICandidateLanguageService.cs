namespace Mytra.Core
{
    public interface ICandidateLanguageService
    {
		Task<Utilize.DataService<CandidateLanguage>> InsertAsync(Utilize.CandidateLanguageInsert Model);
		Task<Utilize.DataService<CandidateLanguage>> UpdateAsync(Utilize.CandidateLanguageUpdate Model);
		Task<Utilize.DataService<CandidateLanguage>> DeleteAsync(Guid Id);
		Task<Utilize.DataService<CandidateLanguage>> SelectAsync(Utilize.CandidateLanguageSelect Model);
		Task<Utilize.DataService<CandidateLanguage>> SelectSingleAsync(Utilize.CandidateLanguageSelectSingle Model);
	}
}