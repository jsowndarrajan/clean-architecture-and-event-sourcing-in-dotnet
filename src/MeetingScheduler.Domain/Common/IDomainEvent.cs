namespace MeetingScheduler.Domain.Common;

public interface IDomainEvent
{
    Guid AggregateRootId { get; }
    int Version { get; }
}