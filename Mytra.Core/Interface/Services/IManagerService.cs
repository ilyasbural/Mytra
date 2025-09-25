namespace Mytra.Core
{
    public interface IManagerService
    {
		Task<Utilize.DataService<Manager>> InsertAsync(Utilize.ManagerInsert Model);
		Task<Utilize.DataService<Manager>> UpdateAsync(Utilize.ManagerUpdate Model);
		Task<Utilize.DataService<Manager>> DeleteAsync(Guid Id);
		Task<Utilize.DataService<Manager>> SelectAsync(Utilize.ManagerSelect Model);
		Task<Utilize.DataService<Manager>> SelectSingleAsync(Utilize.ManagerSelectSingle Model);
	}
}