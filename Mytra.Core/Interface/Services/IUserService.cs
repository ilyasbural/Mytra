namespace Mytra.Core
{
    public interface IUserService
    {
		Task<Utilize.DataService<User>> InsertAsync(Utilize.UserInsert Model);
		Task<Utilize.DataService<User>> UpdateAsync(Utilize.UserUpdate Model);
		Task<Utilize.DataService<User>> DeleteAsync(Guid Id);
		Task<Utilize.DataService<User>> SelectAsync(Utilize.UserSelect Model);
		Task<Utilize.DataService<User>> SelectSingleAsync(Utilize.UserSelectSingle Model);
	}
}