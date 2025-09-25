namespace Mytra.Core
{
    public interface IUserAuthenticationService
    {
		Task<Utilize.DataService<UserAuthentication>> InsertAsync(Utilize.UserAuthenticationInsert Model);
		Task<Utilize.DataService<UserAuthentication>> UpdateAsync(Utilize.UserAuthenticationUpdate Model);
		Task<Utilize.DataService<UserAuthentication>> DeleteAsync(Guid Id);
		Task<Utilize.DataService<UserAuthentication>> SelectAsync(Utilize.UserAuthenticationSelect Model);
		Task<Utilize.DataService<UserAuthentication>> SelectSingleAsync(Utilize.UserAuthenticationSelectSingle Model);
	}
}