namespace Mytra.Core
{
    public interface IManagerSettingsService
    {
		Task<Utilize.DataService<ManagerSettings>> InsertAsync(Utilize.ManagerSettingsInsert Model);
		Task<Utilize.DataService<ManagerSettings>> UpdateAsync(Utilize.ManagerSettingsUpdate Model);
		Task<Utilize.DataService<ManagerSettings>> DeleteAsync(Guid Id);
		Task<Utilize.DataService<ManagerSettings>> SelectAsync(Utilize.ManagerSettingsSelect Model);
		Task<Utilize.DataService<ManagerSettings>> SelectSingleAsync(Utilize.ManagerSettingsSelectSingle Model);
	}
}