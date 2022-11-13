using MeetingScheduler.Application.Contracts;

namespace MeetingScheduler.Application.Meetings.Leave;

public class LeaveMeetingInteractor : IInputBoundary<LeaveMeetingInput>
{
    private readonly IOutputBoundary<LeaveMeetingOutput> _outputBoundary;

    public LeaveMeetingInteractor(IOutputBoundary<LeaveMeetingOutput> outputBoundary)
    {
        _outputBoundary = outputBoundary;
    }

    public async Task Process(LeaveMeetingInput request)
    {
        await Task.FromResult(0);
        this._outputBoundary.Populate(new LeaveMeetingOutput());
    }
}