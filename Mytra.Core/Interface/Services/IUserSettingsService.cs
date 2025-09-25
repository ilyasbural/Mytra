namespace Mytra.Core
{
    public interface IUserSettingsService
    {
		Task<Utilize.DataService<UserSettings>> InsertAsync(Utilize.UserSettingsInsert Model);
		Task<Utilize.DataService<UserSettings>> UpdateAsync(Utilize.UserSettingsUpdate Model);
		Task<Utilize.DataService<UserSettings>> DeleteAsync(Guid Id);
		Task<Utilize.DataService<UserSettings>> SelectAsync(Utilize.UserSettingsSelect Model);
		Task<Utilize.DataService<UserSettings>> SelectSingleAsync(Utilize.UserSettingsSelectSingle Model);
	}
}