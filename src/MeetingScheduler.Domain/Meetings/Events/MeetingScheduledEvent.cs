using MeetingScheduler.Domain.Common;

namespace MeetingScheduler.Domain.Meetings.Events;

public class MeetingScheduledEvent : IDomainEvent
{
    public Guid AggregateRootId { get; }
    public int Version { get; }

    public MeetingScheduledEvent(Guid aggregateRootId, int version)
    {
        AggregateRootId = aggregateRootId;
        Version = version;
    }
}