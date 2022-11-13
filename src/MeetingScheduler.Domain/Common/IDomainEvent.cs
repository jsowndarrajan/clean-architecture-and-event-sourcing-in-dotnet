namespace MeetingScheduler.Domain.Common;

public interface IDomainEvent
{
    Guid AggregateRootId { get; }
    long Version { get; }
    DateTimeOffset Timestamp { get; }
}