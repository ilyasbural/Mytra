namespace Mytra.Core
{
    public interface IUserDetailService
    {
		Task<Common.DataService<UserDetail>> InsertAsync(Common.UserDetailInsert Model);
		//Task<Common.ServiceResponse<Common.UserDetailResponse>> UpdateAsync(Common.UserDetailUpdate Model);
		//Task<Common.ServiceResponse<Common.UserDetailResponse>> DeleteAsync(Common.UserDetailDelete Model);
		//Task<Common.ServiceResponse<Common.UserDetailResponse>> SelectAsync(Common.UserDetailSelect Model);
		//Task<Common.ServiceResponse<Common.UserDetailResponse>> SelectSingleAsync(Common.UserDetailSelectSingle Model);
	}
}