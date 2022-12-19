namespace Mytra.Core
{
    public class UserInsertDataTransfer : DataTransferBase<UserInsertDataTransfer>
    {
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string RefreshToken { get; set; } = null!;
        public DateTime RefreshValidDate { get; set; }
    }
}