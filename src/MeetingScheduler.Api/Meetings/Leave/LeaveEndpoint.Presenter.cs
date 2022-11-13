using MeetingScheduler.Application.Adapters;
using MeetingScheduler.Application.Meetings.Leave;

namespace MeetingScheduler.Api.Meetings.Leave;

public class Presenter : IOutputBoundary<LeaveMeetingOutput>
{
    public LeaveMeetingOutput Output { get; private set; }

    public void Populate(LeaveMeetingOutput response)
    {
        Output = response;
    }
}