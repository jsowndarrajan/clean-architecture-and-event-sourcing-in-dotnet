using System.Net.Mail;

namespace MeetingScheduler.Domain.ValueObjects;

public record EmailAddress
{
    public string Value { get; }

    public EmailAddress(string emailAddress)
    {
        try
        {
            var mailAddress = new MailAddress(emailAddress);
            Value = emailAddress;
        }
        catch (FormatException)
        {
            throw new EmailAddressInvalidException("Email Address is invalid");
        }
    }

    public override string ToString()
    {
        return Value;
    }

    public static implicit operator EmailAddress(string value)
    {
        return new EmailAddress(value);
    }
}