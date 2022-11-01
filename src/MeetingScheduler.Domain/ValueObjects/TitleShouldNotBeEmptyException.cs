using MeetingScheduler.Domain.Common;

namespace MeetingScheduler.Domain.ValueObjects;

public class TitleShouldNotBeEmptyException : DomainException
{
    public TitleShouldNotBeEmptyException(string businessMessage) : base(businessMessage)
    {
    }
}