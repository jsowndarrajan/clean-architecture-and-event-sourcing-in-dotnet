using Ardalis.ApiEndpoints;
using MeetingScheduler.Application.Meetings.Leave;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace MeetingScheduler.Api.Meetings.Leave
{
    public class LeaveEndpoint : EndpointBaseAsync
        .WithRequest<LeaveMeetingInput>
        .WithActionResult<LeaveMeetingOutput>
    {
        [HttpPost("api/meetings/leave")]
        [SwaggerOperation(
            Summary = "Leave",
            Description = "Leave a meeting",
            OperationId = "Meetings.Leave",
            Tags = new[] { "Meetings Endpoint" })
        ]
        public override async Task<ActionResult<LeaveMeetingOutput>> HandleAsync(
            LeaveMeetingInput request,
            CancellationToken cancellationToken = new CancellationToken())
        {
            await Task.FromResult(0);

            return new LeaveMeetingOutput();
        }
    }
}
