using MeetingScheduler.Domain.Common;

namespace MeetingScheduler.Domain.ValueObjects;

public class TimeRangeInvalidException : DomainException
{
    public TimeRangeInvalidException(string businessMessage) : base(businessMessage)
    {
    }
}