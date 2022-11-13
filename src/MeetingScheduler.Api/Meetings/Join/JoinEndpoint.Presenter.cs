using MeetingScheduler.Application.Contracts;
using MeetingScheduler.Application.Meetings.Join;

namespace MeetingScheduler.Api.Meetings.Join;

public class Presenter : IOutputBoundary<JoinMeetingOutput>
{
    public JoinMeetingOutput Output { get; private set; }

    public void Populate(JoinMeetingOutput response)
    {
        Output = response;
    }
}