using Ardalis.ApiEndpoints;
using MeetingScheduler.Application.Meetings.Start;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace MeetingScheduler.Api.Meetings.Start;

public class StartEndpoint : EndpointBaseAsync
    .WithRequest<StartMeetingInput>
    .WithActionResult<StartMeetingOutput>
{
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
        await Task.FromResult(0);

        return new StartMeetingOutput();
    }
}