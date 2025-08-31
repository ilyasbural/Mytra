namespace Mytra.Core
{
    public interface ICandidateLanguageService
    {
		Task<Common.DataService<CandidateLanguage>> InsertAsync(Common.CandidateLanguageInsert Model);
		Task<Common.DataService<CandidateLanguage>> UpdateAsync(Common.CandidateLanguageUpdate Model);
		Task<Common.DataService<CandidateLanguage>> DeleteAsync(Common.CandidateLanguageDelete Model);
		Task<Common.DataService<CandidateLanguage>> SelectAsync(Common.CandidateLanguageSelect Model);
		Task<Common.DataService<CandidateLanguage>> SelectSingleAsync(Common.CandidateLanguageSelectSingle Model);
	}
}