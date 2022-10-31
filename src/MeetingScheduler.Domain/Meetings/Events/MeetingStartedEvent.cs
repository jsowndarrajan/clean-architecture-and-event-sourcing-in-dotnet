using MeetingScheduler.Domain.Common;

namespace MeetingScheduler.Domain.Meetings.Events;

public class MeetingStartedEvent: IDomainEvent
{
    public Guid AggregateRootId { get; }
    public int Version { get; }

    public MeetingStartedEvent(Guid aggregateRootId, int version)
    {
        AggregateRootId = aggregateRootId;
        Version = version;
    }
}