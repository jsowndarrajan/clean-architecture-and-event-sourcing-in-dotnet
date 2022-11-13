using Ardalis.ApiEndpoints;
using MeetingScheduler.Application.Contracts;
using MeetingScheduler.Application.Meetings.Join;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace MeetingScheduler.Api.Meetings.Join;

public class JoinEndpoint : EndpointBaseAsync
    .WithRequest<JoinMeetingInput>
    .WithActionResult<JoinMeetingOutput>
{
    private readonly IInputBoundary<JoinMeetingInput> _inputBoundary;
    private readonly IOutputBoundary<JoinMeetingOutput> _outputBoundary;

    public JoinEndpoint(
        IInputBoundary<JoinMeetingInput> inputBoundary,
        IOutputBoundary<JoinMeetingOutput> presenter)
    {
        _inputBoundary = inputBoundary;
        _outputBoundary = presenter;
    }

    [HttpPost("api/meetings/join")]
    [SwaggerOperation(
        Summary = "Join",
        Description = "Join a meeting",
        OperationId = "Meetings.Join",
        Tags = new[] { "Meetings Endpoint" })
    ]
    public override async Task<ActionResult<JoinMeetingOutput>> HandleAsync(
        JoinMeetingInput request,
        CancellationToken cancellationToken = new CancellationToken())
    {
        await _inputBoundary.Process(request);
        return _outputBoundary.Output;
    }
}