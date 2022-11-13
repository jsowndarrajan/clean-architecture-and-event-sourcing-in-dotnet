using MeetingScheduler.Application.Contracts;

namespace MeetingScheduler.Application.Meetings.Start;

public class StartMeetingInteractor : IInputBoundary<StartMeetingInput>
{
    private readonly IOutputBoundary<StartMeetingOutput> _outputBoundary;

    public StartMeetingInteractor(IOutputBoundary<StartMeetingOutput> outputBoundary)
    {
        _outputBoundary = outputBoundary;
    }

    public async Task Process(StartMeetingInput request)
    {
        await Task.FromResult(0);
        _outputBoundary.Populate(new StartMeetingOutput());
    }
}