namespace Mytra.Core
{
    public interface ILanguageService
    {
		Task<Common.DataService<Language>> InsertAsync(Common.LanguageInsert Model);
		//Task<Common.ServiceResponse<Common.LanguageResponse>> UpdateAsync(Common.LanguageUpdate Model);
		//Task<Common.ServiceResponse<Common.LanguageResponse>> DeleteAsync(Common.LanguageDelete Model);
		//Task<Common.ServiceResponse<Common.LanguageResponse>> SelectAsync(Common.LanguageSelect Model);
		//Task<Common.ServiceResponse<Common.LanguageResponse>> SelectSingleAsync(Common.LanguageSelectSingle Model);
	}
}