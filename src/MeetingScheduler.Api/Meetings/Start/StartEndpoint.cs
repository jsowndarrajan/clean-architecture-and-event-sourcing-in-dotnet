using Ardalis.ApiEndpoints;
using MeetingScheduler.Application.Contracts;
using MeetingScheduler.Application.Meetings.Start;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace MeetingScheduler.Api.Meetings.Start;

public class StartEndpoint : EndpointBaseAsync
    .WithRequest<StartMeetingInput>
    .WithActionResult<StartMeetingOutput>
{
    private readonly IInputBoundary<StartMeetingInput> _inputBoundary;
    private readonly IOutputBoundary<StartMeetingOutput> _outputBoundary;

    public StartEndpoint(
        IInputBoundary<StartMeetingInput> inputBoundary,
        IOutputBoundary<StartMeetingOutput> presenter)
    {
        _inputBoundary = inputBoundary;
        _outputBoundary = presenter;
    }

    [HttpPost("api/meetings/start")]
    [SwaggerOperation(
        Summary = "Start",
        Description = "Start a meeting",
        OperationId = "Meetings.Start",
        Tags = new[] { "Meetings Endpoint" })
    ]
    public override async Task<ActionResult<StartMeetingOutput>> HandleAsync(
        StartMeetingInput request,
        CancellationToken cancellationToken = new CancellationToken())
    {
        await _inputBoundary.Process(request);
        return _outputBoundary.Output;
    }
}