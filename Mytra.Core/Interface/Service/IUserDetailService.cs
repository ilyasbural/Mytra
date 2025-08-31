namespace Mytra.Core
{
    public interface IUserDetailService
    {
		Task<Common.DataService<UserDetail>> InsertAsync(Common.UserDetailInsert Model);
		Task<Common.DataService<UserDetail>> UpdateAsync(Common.UserDetailUpdate Model);
		Task<Common.DataService<UserDetail>> DeleteAsync(Common.UserDetailDelete Model);
		Task<Common.DataService<UserDetail>> SelectAsync(Common.UserDetailSelect Model);
		Task<Common.DataService<UserDetail>> SelectSingleAsync(Common.UserDetailSelectSingle Model);
	}
}