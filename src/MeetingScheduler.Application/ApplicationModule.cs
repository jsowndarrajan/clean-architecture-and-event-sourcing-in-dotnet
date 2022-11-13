using MeetingScheduler.Application.Adapters;
using MeetingScheduler.Application.Meetings.Join;
using Microsoft.Extensions.DependencyInjection;

namespace MeetingScheduler.Application;

public static class ApplicationModule
{
    public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
    {
        services.AddTransient<IInputBoundary<JoinMeetingInput>, JoinMeetingInteractor>();
        return services;
    }
}