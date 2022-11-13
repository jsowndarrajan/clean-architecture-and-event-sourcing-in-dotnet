using MeetingScheduler.Api.Meetings.Schedule;
using MeetingScheduler.Application.Adapters;
using MeetingScheduler.Application.Meetings.Join;
using MeetingScheduler.Application.Meetings.Leave;
using MeetingScheduler.Application.Meetings.Schedule;
using MeetingScheduler.Application.Meetings.Start;
using Microsoft.Extensions.DependencyInjection;

namespace MeetingScheduler.Application;

public static class ApplicationModule
{
    public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
    {
        services.AddTransient<IInputBoundary<JoinMeetingInput>, JoinMeetingInteractor>();
        services.AddTransient<IInputBoundary<LeaveMeetingInput>, LeaveMeetingInteractor>();
        services.AddTransient<IInputBoundary<ScheduleMeetingInput>, ScheduleMeetingInteractor>();
        services.AddTransient<IInputBoundary<StartMeetingInput>, StartMeetingInteractor>();
        return services;
    }
}