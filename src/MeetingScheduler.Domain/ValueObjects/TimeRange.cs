namespace MeetingScheduler.Domain.ValueObjects;

public record TimeRange
{
    public DateTime Start { get; }

    public DateTime End { get; }

    public TimeSpan Duration => End.Subtract(Start);

    public TimeRange(DateTime start, DateTime end)
    {
        if (end < start)
        {
            throw new TimeRangeInvalidException("The start time should be less than the end time");
        }

        Start = start;
        End = end;
    }

    public override string ToString()
    {
        return $"Start: {Start:yyyy-MM-dd HH:mm} End: {End:yyyy-MM-dd HH:mm}";
    }
}

