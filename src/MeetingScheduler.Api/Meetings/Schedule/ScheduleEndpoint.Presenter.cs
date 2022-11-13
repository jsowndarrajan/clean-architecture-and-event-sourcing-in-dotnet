using MeetingScheduler.Application.Adapters;
using MeetingScheduler.Application.Meetings.Schedule;

namespace MeetingScheduler.Api.Meetings.Schedule;

public class Presenter : IOutputBoundary<ScheduleMeetingOutput>
{
    public ScheduleMeetingOutput Output { get; }

    public void Populate(ScheduleMeetingOutput response)
    {
        throw new NotImplementedException();
    }
}