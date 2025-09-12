namespace Mytra.Core
{
    public interface IInstitutionService
    {
		Task<Common.DataService<Institution>> InsertAsync(Common.InstitutionInsert Model);
		Task<Common.DataService<Institution>> UpdateAsync(Common.InstitutionUpdate Model);
		Task<Common.DataService<Institution>> DeleteAsync(Guid Id);
		Task<Common.DataService<Institution>> SelectAsync(Common.InstitutionSelect Model);
		Task<Common.DataService<Institution>> SelectSingleAsync(Common.InstitutionSelectSingle Model);
	}
}