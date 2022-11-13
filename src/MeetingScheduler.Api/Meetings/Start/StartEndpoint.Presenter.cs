using MeetingScheduler.Application.Contracts;
using MeetingScheduler.Application.Meetings.Start;

namespace MeetingScheduler.Api.Meetings.Start;

public class Presenter : IOutputBoundary<StartMeetingOutput>
{
    public StartMeetingOutput Output { get; private set; }

    public void Populate(StartMeetingOutput response)
    {
        Output = response;
    }
}