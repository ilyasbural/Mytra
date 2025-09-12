namespace Mytra.Core
{
    public interface IUserSettingsService
    {
		Task<Common.DataService<UserSettings>> InsertAsync(Common.UserSettingsInsert Model);
		Task<Common.DataService<UserSettings>> UpdateAsync(Common.UserSettingsUpdate Model);
		Task<Common.DataService<UserSettings>> DeleteAsync(Guid Id);
		Task<Common.DataService<UserSettings>> SelectAsync(Common.UserSettingsSelect Model);
		Task<Common.DataService<UserSettings>> SelectSingleAsync(Common.UserSettingsSelectSingle Model);
	}
}