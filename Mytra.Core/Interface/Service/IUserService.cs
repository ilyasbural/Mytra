namespace Mytra.Core
{
    public interface IUserService
    {
		Task<Common.DataService<User>> InsertAsync(Common.UserInsert Model);
		Task<Common.DataService<User>> UpdateAsync(Common.UserUpdate Model);
		Task<Common.DataService<User>> DeleteAsync(Guid Id);
		Task<Common.DataService<User>> SelectAsync(Common.UserSelect Model);
		Task<Common.DataService<User>> SelectSingleAsync(Common.UserSelectSingle Model);
	}
}