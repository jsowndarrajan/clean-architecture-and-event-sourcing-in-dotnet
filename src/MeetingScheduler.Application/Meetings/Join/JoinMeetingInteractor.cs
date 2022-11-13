using MeetingScheduler.Application.Contracts;

namespace MeetingScheduler.Application.Meetings.Join;

public class JoinMeetingInteractor : IInputBoundary<JoinMeetingInput>
{
    private readonly IOutputBoundary<JoinMeetingOutput> _outputBoundary;

    public JoinMeetingInteractor(IOutputBoundary<JoinMeetingOutput> outputBoundary)
    {
        _outputBoundary = outputBoundary;
    }

    public async Task Process(JoinMeetingInput request)
    {
        await Task.FromResult(0);
        _outputBoundary.Populate(new JoinMeetingOutput());
    }
}