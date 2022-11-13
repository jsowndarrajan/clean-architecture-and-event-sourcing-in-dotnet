using Ardalis.ApiEndpoints;
using MeetingScheduler.Application.Meetings.Schedule;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace MeetingScheduler.Api.Meetings.Schedule;

public class ScheduleEndpoint : EndpointBaseAsync
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
    public override async Task<ActionResult<ScheduleMeetingOutput>> HandleAsync(
        ScheduleMeetingInput request,
        CancellationToken cancellationToken = new CancellationToken())
    {
        await Task.FromResult(0);

        return new ScheduleMeetingOutput();
    }
}