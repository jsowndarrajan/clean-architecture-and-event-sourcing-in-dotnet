namespace MeetingScheduler.Domain.Common
{
    public interface IAggregateRoot : IEntity
    {
        long Version { get; }
    }
}
