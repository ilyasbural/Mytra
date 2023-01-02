namespace Mytra.Core
{
    public class UserDetail : Base<UserDetail>, IEntity
    {
        public string? Name { get; set; }
        public string? Lastname { get; set; }
        public DateTime? Birthdate { get; set; }
        public byte? Gender { get; set; }

        public virtual User IdNavigation { get; set; } = null!;
    }
}