using MeetingScheduler.Application.Contracts;

namespace MeetingScheduler.Application.Meetings.Schedule;

public class ScheduleMeetingInteractor : IInputBoundary<ScheduleMeetingInput>
{
    private readonly IOutputBoundary<ScheduleMeetingOutput> _outputBoundary;

    public ScheduleMeetingInteractor(IOutputBoundary<ScheduleMeetingOutput> outputBoundary)
    {
        _outputBoundary = outputBoundary;
    }

    public async Task Process(ScheduleMeetingInput request)
    {
        await Task.FromResult(0);
        _outputBoundary.Populate(new ScheduleMeetingOutput());
    }
}