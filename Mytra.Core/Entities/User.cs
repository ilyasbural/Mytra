namespace Mytra.Core
{
    public class User : Base<User>, IEntity
    {
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshValidDate { get; set; }

        public virtual ICollection<ContentComment> ContentComments { get; } = new List<ContentComment>();
        public virtual ICollection<ContentLike> ContentLikes { get; } = new List<ContentLike>();
        public virtual ICollection<SurveyDetail> SurveyDetails { get; } = new List<SurveyDetail>();
        public virtual ICollection<UserContact> UserContacts { get; } = new List<UserContact>();
        public virtual UserDetail? UserDetail { get; set; }
        public virtual ICollection<UserEmail> UserEmails { get; } = new List<UserEmail>();
        public virtual UserSettings? UserSettings { get; set; }
    }
}