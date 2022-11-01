namespace MeetingScheduler.Domain.ValueObjects;

public class Title
{
    public string Value { get; }

    public Title(string title)
    {
        if (string.IsNullOrWhiteSpace(title))
        {
            throw new TitleShouldNotBeEmptyException("The 'Title' field is required");
        }

        Value = title;
    }

    public override string ToString()
    {
        return Value;
    }

    public static implicit operator Title(string title)
    {
        return new Title(title);
    }
}