namespace Mytra.Core
{
    public interface IManagerDetailService
    {
		Task<Utilize.DataService<ManagerDetail>> InsertAsync(Utilize.ManagerDetailInsert Model);
		Task<Utilize.DataService<ManagerDetail>> UpdateAsync(Utilize.ManagerDetailUpdate Model);
		Task<Utilize.DataService<ManagerDetail>> DeleteAsync(Guid Id);
		Task<Utilize.DataService<ManagerDetail>> SelectAsync(Utilize.ManagerDetailSelect Model);
		Task<Utilize.DataService<ManagerDetail>> SelectSingleAsync(Utilize.ManagerDetailSelectSingle Model);
	}
}