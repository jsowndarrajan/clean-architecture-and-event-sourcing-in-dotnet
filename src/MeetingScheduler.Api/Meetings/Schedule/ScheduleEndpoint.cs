using Ardalis.ApiEndpoints;
using MeetingScheduler.Application.Adapters;
using MeetingScheduler.Application.Meetings.Schedule;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace MeetingScheduler.Api.Meetings.Schedule;

public class ScheduleEndpoint : EndpointBaseAsync
    .WithRequest<ScheduleMeetingInput>
    .WithActionResult<ScheduleMeetingOutput>
{
    private readonly IInputBoundary<ScheduleMeetingInput> _inputBoundary;
    private readonly IOutputBoundary<ScheduleMeetingOutput> _outputBoundary;

    public ScheduleEndpoint(
        IInputBoundary<ScheduleMeetingInput> inputBoundary,
        IOutputBoundary<ScheduleMeetingOutput> presenter)
    {
        _inputBoundary = inputBoundary;
        _outputBoundary = presenter;
    }

    [HttpPost("api/meetings/schedule")]
    [SwaggerOperation(
        Summary = "Schedule",
        Description = "Schedule a meeting",
        OperationId = "Meetings.Schedule",
        Tags = new[] { "Meetings Endpoint" })
    ]
    public override async Task<ActionResult<ScheduleMeetingOutput>> HandleAsync(
        ScheduleMeetingInput request,
        CancellationToken cancellationToken = new CancellationToken())
    {
        await _inputBoundary.Process(request);
        return _outputBoundary.Output;
    }
}