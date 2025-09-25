namespace Mytra.Core
{
    public interface ILanguageService
    {
		Task<Utilize.DataService<Language>> InsertAsync(Utilize.LanguageInsert Model);
		Task<Utilize.DataService<Language>> UpdateAsync(Utilize.LanguageUpdate Model);
		Task<Utilize.DataService<Language>> DeleteAsync(Guid Id);
		Task<Utilize.DataService<Language>> SelectAsync(Utilize.LanguageSelect Model);
		Task<Utilize.DataService<Language>> SelectSingleAsync(Utilize.LanguageSelectSingle Model);
	}
}