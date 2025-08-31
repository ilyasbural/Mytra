namespace Mytra.Core
{
    public interface IUserService
    {
		Task<Common.DataService<User>> InsertAsync(Common.UserInsert Model);
		//Task<Common.ServiceResponse<Common.UserResponse>> UpdateAsync(Common.UserUpdate Model);
		//Task<Common.ServiceResponse<Common.UserResponse>> DeleteAsync(Common.UserDelete Model);
		//Task<Common.ServiceResponse<Common.UserResponse>> SelectAsync(Common.UserSelect Model);
		//Task<Common.ServiceResponse<Common.UserResponse>> SelectSingleAsync(Common.UserSelectSingle Model);
	}
}