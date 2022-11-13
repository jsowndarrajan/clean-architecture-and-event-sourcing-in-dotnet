using Ardalis.ApiEndpoints;
using MeetingScheduler.Application.Adapters;
using MeetingScheduler.Application.Meetings.Leave;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace MeetingScheduler.Api.Meetings.Leave
{
    public class LeaveEndpoint : EndpointBaseAsync
        .WithRequest<LeaveMeetingInput>
        .WithActionResult<LeaveMeetingOutput>
    {
        private readonly IInputBoundary<LeaveMeetingInput> _inputBoundary;
        private readonly IOutputBoundary<LeaveMeetingOutput> _outputBoundary;

        public LeaveEndpoint(
            IInputBoundary<LeaveMeetingInput> inputBoundary,
            IOutputBoundary<LeaveMeetingOutput> presenter)
        {
            _inputBoundary = inputBoundary;
            _outputBoundary = presenter;
        }

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
            await _inputBoundary.Process(request);
            return _outputBoundary.Output;
        }
    }
}
