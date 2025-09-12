namespace Mytra.Core
{
    public interface IManagerDetailService
    {
		Task<Common.DataService<ManagerDetail>> InsertAsync(Common.ManagerDetailInsert Model);
		Task<Common.DataService<ManagerDetail>> UpdateAsync(Common.ManagerDetailUpdate Model);
		Task<Common.DataService<ManagerDetail>> DeleteAsync(Guid Id);
		Task<Common.DataService<ManagerDetail>> SelectAsync(Common.ManagerDetailSelect Model);
		Task<Common.DataService<ManagerDetail>> SelectSingleAsync(Common.ManagerDetailSelectSingle Model);
	}
}