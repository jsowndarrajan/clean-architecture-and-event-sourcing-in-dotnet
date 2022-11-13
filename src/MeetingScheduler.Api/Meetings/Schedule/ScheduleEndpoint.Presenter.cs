using MeetingScheduler.Application.Contracts;
using MeetingScheduler.Application.Meetings.Schedule;

namespace MeetingScheduler.Api.Meetings.Schedule;

public class Presenter : IOutputBoundary<ScheduleMeetingOutput>
{
    public ScheduleMeetingOutput Output { get; private set; }

    public void Populate(ScheduleMeetingOutput response)
    {
        Output = response;
    }
}