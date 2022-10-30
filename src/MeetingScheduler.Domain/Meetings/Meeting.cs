using MeetingScheduler.Domain.Common;
using MeetingScheduler.Domain.ValueObjects;

namespace MeetingScheduler.Domain.Meetings
{
    public class Meeting : IEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public TimeRange TimeRange { get; set; }
        public IEnumerable<string> Attendees { get; set; }
        public IEnumerable<string> Organizer { get; set; }
        public MeetingStatus Status { get; set; }
    }
}
