namespace Mytra.Core
{
    public interface IUserDetailService
    {
		Task<Utilize.DataService<UserDetail>> InsertAsync(Utilize.UserDetailInsert Model);
		Task<Utilize.DataService<UserDetail>> UpdateAsync(Utilize.UserDetailUpdate Model);
		Task<Utilize.DataService<UserDetail>> DeleteAsync(Guid Id);
		Task<Utilize.DataService<UserDetail>> SelectAsync(Utilize.UserDetailSelect Model);
		Task<Utilize.DataService<UserDetail>> SelectSingleAsync(Utilize.UserDetailSelectSingle Model);
	}
}