namespace Mytra.Core
{
    public interface ILanguageService
    {
		Task<Common.DataService<Language>> InsertAsync(Common.LanguageInsert Model);
		Task<Common.DataService<Language>> UpdateAsync(Common.LanguageUpdate Model);
		Task<Common.DataService<Language>> DeleteAsync(Guid Id);
		Task<Common.DataService<Language>> SelectAsync(Common.LanguageSelect Model);
		Task<Common.DataService<Language>> SelectSingleAsync(Common.LanguageSelectSingle Model);
	}
}