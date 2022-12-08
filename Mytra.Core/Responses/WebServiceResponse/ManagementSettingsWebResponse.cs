namespace Mytra.Core
{
    public class ManagementSettingsWebResponse : BaseWebResponse<ManagementSettingsWebResponse>
    {
        public ManagementSettings ManagementSettings { get; set; } = null!;
    }
}