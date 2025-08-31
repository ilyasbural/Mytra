namespace Mytra.Core
{
    public interface IManagerAuthenticationService
    {
		Task<Common.DataService<ManagerAuthentication>> InsertAsync(Common.ManagerAuthenticationInsert Model);
		Task<Common.DataService<ManagerAuthentication>> UpdateAsync(Common.ManagerAuthenticationUpdate Model);
		Task<Common.DataService<ManagerAuthentication>> DeleteAsync(Common.ManagerAuthenticationDelete Model);
		Task<Common.DataService<ManagerAuthentication>> SelectAsync(Common.ManagerAuthenticationSelect Model);
		Task<Common.DataService<ManagerAuthentication>> SelectSingleAsync(Common.ManagerAuthenticationSelectSingle Model);
	}
}