namespace Mytra.Core
{
    public interface IManagerAuthenticationService
    {
		Task<Common.DataService<ManagerAuthentication>> InsertAsync(Common.ManagerAuthenticationInsert Model);
		//Task<Common.ServiceResponse<Common.ManagerAuthenticationResponse>> UpdateAsync(Common.ManagerAuthenticationUpdate Model);
		//Task<Common.ServiceResponse<Common.ManagerAuthenticationResponse>> DeleteAsync(Common.ManagerAuthenticationDelete Model);
		//Task<Common.ServiceResponse<Common.ManagerAuthenticationResponse>> SelectAsync(Common.ManagerAuthenticationSelect Model);
		//Task<Common.ServiceResponse<Common.ManagerAuthenticationResponse>> SelectSingleAsync(Common.ManagerAuthenticationSelectSingle Model);
	}
}