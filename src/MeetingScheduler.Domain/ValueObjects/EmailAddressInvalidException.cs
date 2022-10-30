using MeetingScheduler.Domain.Common;

namespace MeetingScheduler.Domain.ValueObjects;

public class EmailAddressInvalidException : DomainException
{
    public EmailAddressInvalidException(string businessMessage)
        : base(businessMessage)
    {
    }
}