namespace Mytra.Core
{
    public interface IUserAuthenticationService
    {
		Task<Common.DataService<UserAuthentication>> InsertAsync(Common.UserAuthenticationInsert Model);
		//Task<Common.ServiceResponse<Common.UserAuthenticationResponse>> UpdateAsync(Common.UserAuthenticationUpdate Model);
		//Task<Common.ServiceResponse<Common.UserAuthenticationResponse>> DeleteAsync(Common.UserAuthenticationDelete Model);
		//Task<Common.ServiceResponse<Common.UserAuthenticationResponse>> SelectAsync(Common.UserAuthenticationSelect Model);
		//Task<Common.ServiceResponse<Common.UserAuthenticationResponse>> SelectSingleAsync(Common.UserAuthenticationSelectSingle Model);
	}
}