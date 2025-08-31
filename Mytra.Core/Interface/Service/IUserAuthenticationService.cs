namespace Mytra.Core
{
    public interface IUserAuthenticationService
    {
		Task<Common.DataService<UserAuthentication>> InsertAsync(Common.UserAuthenticationInsert Model);
		Task<Common.DataService<UserAuthentication>> UpdateAsync(Common.UserAuthenticationUpdate Model);
		Task<Common.DataService<UserAuthentication>> DeleteAsync(Common.UserAuthenticationDelete Model);
		Task<Common.DataService<UserAuthentication>> SelectAsync(Common.UserAuthenticationSelect Model);
		Task<Common.DataService<UserAuthentication>> SelectSingleAsync(Common.UserAuthenticationSelectSingle Model);
	}
}