namespace Mytra.Core
{
    public interface IManagerService
    {
		Task<Common.DataService<Manager>> InsertAsync(Common.ManagerInsert Model);
		//Task<Common.ServiceResponse<Common.ManagerResponse>> UpdateAsync(Common.ManagerUpdate Model);
		//Task<Common.ServiceResponse<Common.ManagerResponse>> DeleteAsync(Common.ManagerDelete Model);
		//Task<Common.ServiceResponse<Common.ManagerResponse>> SelectAsync(Common.ManagerSelect Model);
		//Task<Common.ServiceResponse<Common.ManagerResponse>> SelectSingleAsync(Common.ManagerSelectSingle Model);
	}
}