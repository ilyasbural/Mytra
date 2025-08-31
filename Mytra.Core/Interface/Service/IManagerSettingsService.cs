namespace Mytra.Core
{
    public interface IManagerSettingsService
    {
		Task<Common.DataService<ManagerSettings>> InsertAsync(Common.ManagerSettingsInsert Model);
		Task<Common.DataService<ManagerSettings>> UpdateAsync(Common.ManagerSettingsUpdate Model);
		Task<Common.DataService<ManagerSettings>> DeleteAsync(Common.ManagerSettingsDelete Model);
		Task<Common.DataService<ManagerSettings>> SelectAsync(Common.ManagerSettingsSelect Model);
		Task<Common.DataService<ManagerSettings>> SelectSingleAsync(Common.ManagerSettingsSelectSingle Model);
	}
}