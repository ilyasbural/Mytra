namespace Mytra.Core
{
    public interface IManagerAuthenticationService
    {
		Task<Utilize.DataService<ManagerAuthentication>> InsertAsync(Utilize.ManagerAuthenticationInsert Model);
		Task<Utilize.DataService<ManagerAuthentication>> UpdateAsync(Utilize.ManagerAuthenticationUpdate Model);
		Task<Utilize.DataService<ManagerAuthentication>> DeleteAsync(Guid Id);
		Task<Utilize.DataService<ManagerAuthentication>> SelectAsync(Utilize.ManagerAuthenticationSelect Model);
		Task<Utilize.DataService<ManagerAuthentication>> SelectSingleAsync(Utilize.ManagerAuthenticationSelectSingle Model);
	}
}