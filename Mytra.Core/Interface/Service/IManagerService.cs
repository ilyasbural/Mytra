namespace Mytra.Core
{
    public interface IManagerService
    {
		Task<Common.DataService<Manager>> InsertAsync(Common.ManagerInsert Model);
		Task<Common.DataService<Manager>> UpdateAsync(Common.ManagerUpdate Model);
		Task<Common.DataService<Manager>> DeleteAsync(Common.ManagerDelete Model);
		Task<Common.DataService<Manager>> SelectAsync(Common.ManagerSelect Model);
		Task<Common.DataService<Manager>> SelectSingleAsync(Common.ManagerSelectSingle Model);
	}
}