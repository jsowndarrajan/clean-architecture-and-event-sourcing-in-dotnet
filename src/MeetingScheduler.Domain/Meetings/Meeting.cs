using MeetingScheduler.Domain.Common;
using MeetingScheduler.Domain.ValueObjects;

namespace MeetingScheduler.Domain.Meetings
{
    public class Meeting : AggregateRoot
    {
        public Title Title { get; }
        public TimeRange TimeRange { get; }
        public IEnumerable<EmailAddress> Attendees { get; }
        public EmailAddress Organizer { get; }
        public MeetingStatus Status { get; }
    }
}
