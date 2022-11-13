using MeetingScheduler.Domain.Common;
using MeetingScheduler.Domain.ValueObjects;

namespace MeetingScheduler.Domain.Meetings.Events;

public class MeetingStartedEvent: IDomainEvent
{
    public Guid AggregateRootId { get; }
    public long Version { get; }
    public EmailAddress StartedBy { get; }
    public DateTimeOffset Timestamp { get; }

    public MeetingStartedEvent(
        Guid aggregateRootId,
        int version,
        EmailAddress startedBy)
    {
        AggregateRootId = aggregateRootId;
        Version = version;
        StartedBy = startedBy;
        Timestamp = DateTimeOffset.UtcNow;
    }
}