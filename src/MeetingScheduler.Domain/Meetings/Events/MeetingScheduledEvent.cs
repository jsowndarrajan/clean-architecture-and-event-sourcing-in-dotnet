using MeetingScheduler.Domain.Common;
using MeetingScheduler.Domain.ValueObjects;

namespace MeetingScheduler.Domain.Meetings.Events;

public class MeetingScheduledEvent : IDomainEvent
{
    public Guid AggregateRootId { get; }
    public int Version { get; }
    public Title Title { get; }
    public TimeRange TimeRange { get; }
    public IEnumerable<EmailAddress> Attendees { get; }
    public EmailAddress Organizer { get; }
    public DateTimeOffset Timestamp { get; }

    public MeetingScheduledEvent(
        Guid aggregateRootId,
        int version,
        Title title,
        TimeRange timeRange,
        IEnumerable<EmailAddress> attendees,
        EmailAddress organizer)
    {
        AggregateRootId = aggregateRootId;
        Version = version;
        Title = title;
        TimeRange = timeRange;
        Attendees = attendees;
        Organizer = organizer;
        Timestamp = DateTimeOffset.UtcNow;
    }
}