namespace Mytra.Core
{
    public interface IManagerSettingsService
    {
		Task<Common.DataService<ManagerSettings>> InsertAsync(Common.ManagerSettingsInsert Model);
		//Task<Common.ServiceResponse<Common.ManagerSettingsResponse>> UpdateAsync(Common.ManagerSettingsUpdate Model);
		//Task<Common.ServiceResponse<Common.ManagerSettingsResponse>> DeleteAsync(Common.ManagerSettingsDelete Model);
		//Task<Common.ServiceResponse<Common.ManagerSettingsResponse>> SelectAsync(Common.ManagerSettingsSelect Model);
		//Task<Common.ServiceResponse<Common.ManagerSettingsResponse>> SelectSingleAsync(Common.ManagerSettingsSelectSingle Model);
	}
}