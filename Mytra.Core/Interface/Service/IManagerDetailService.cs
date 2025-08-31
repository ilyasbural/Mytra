namespace Mytra.Core
{
    public interface IManagerDetailService
    {
		Task<Common.DataService<ManagerDetail>> InsertAsync(Common.ManagerDetailInsert Model);
		//Task<Common.ServiceResponse<Common.ManagerDetailResponse>> UpdateAsync(Common.ManagerDetailUpdate Model);
		//Task<Common.ServiceResponse<Common.ManagerDetailResponse>> DeleteAsync(Common.ManagerDetailDelete Model);
		//Task<Common.ServiceResponse<Common.ManagerDetailResponse>> SelectAsync(Common.ManagerDetailSelect Model);
		//Task<Common.ServiceResponse<Common.ManagerDetailResponse>> SelectSingleAsync(Common.ManagerDetailSelectSingle Model);
	}
}