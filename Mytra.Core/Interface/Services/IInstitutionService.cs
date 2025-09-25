namespace Mytra.Core
{
    public interface IInstitutionService
    {
		Task<Utilize.DataService<Institution>> InsertAsync(Utilize.InstitutionInsert Model);
		Task<Utilize.DataService<Institution>> UpdateAsync(Utilize.InstitutionUpdate Model);
		Task<Utilize.DataService<Institution>> DeleteAsync(Guid Id);
		Task<Utilize.DataService<Institution>> SelectAsync(Utilize.InstitutionSelect Model);
		Task<Utilize.DataService<Institution>> SelectSingleAsync(Utilize.InstitutionSelectSingle Model);
	}
}