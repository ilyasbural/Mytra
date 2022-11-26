namespace Mytra.Core
{
    public class Management : Base<Management>, IEntity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RefreshToken { get; set; }
        public DateTime RefreshValidDate { get; set; }
    }
}