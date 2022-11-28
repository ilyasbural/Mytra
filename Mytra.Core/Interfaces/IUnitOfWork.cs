namespace Mytra.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IAnnounce Announce { get; }
    }
}