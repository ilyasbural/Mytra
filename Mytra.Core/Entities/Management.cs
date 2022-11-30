namespace Mytra.Core
{
    public class Management : Base<Management>
    {
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshValidDate { get; set; }
        public virtual ICollection<ManagementContact> ManagementContacts { get; } = new List<ManagementContact>();
        public virtual ManagementDetail? ManagementDetail { get; set; }
        public virtual ManagementSettings? ManagementSetting { get; set; }
    }
}