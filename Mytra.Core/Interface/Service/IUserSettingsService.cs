namespace Mytra.Core
{
    public interface IUserSettingsService
    {
		Task<Common.DataService<UserSettings>> InsertAsync(Common.UserSettingsInsert Model);
		//Task<Common.ServiceResponse<Common.UserSettingsResponse>> UpdateAsync(Common.UserSettingsUpdate Model);
		//Task<Common.ServiceResponse<Common.UserSettingsResponse>> DeleteAsync(Common.UserSettingsDelete Model);
		//Task<Common.ServiceResponse<Common.UserSettingsResponse>> SelectAsync(Common.UserSettingsSelect Model);
		//Task<Common.ServiceResponse<Common.UserSettingsResponse>> SelectSingleAsync(Common.UserSettingsSelectSingle Model);
	}
}