using Ardalis.ApiEndpoints;
using MeetingScheduler.Application.Meetings.Schedule;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace MeetingScheduler.Api.Meetings.Schedule;

public class ScheduleMeeting : EndpointBaseAsync
    .WithRequest<ScheduleMeetingInput>
    .WithActionResult<ScheduleMeetingOutput>
{
    [HttpPost("api/meetings/schedule")]
    [SwaggerOperation(
        Summary = "Schedule",
        Description = "Schedule a meeting",
        OperationId = "Meetings.Schedule",
        Tags = new[] { "Meetings Endpoint" })
    ]
    public override Task<ActionResult<ScheduleMeetingOutput>> HandleAsync(
        ScheduleMeetingInput request,
        CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }
}