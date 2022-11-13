using MeetingScheduler.Application;
using MeetingScheduler.Application.Adapters;
using MeetingScheduler.Application.Meetings.Join;
using Microsoft.OpenApi.Models;

namespace MeetingScheduler.Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Meeting Scheduler", Version = "v1" });
            c.EnableAnnotations();
        });

        builder.Services.AddTransient<IOutputBoundary<JoinMeetingOutput>, Meetings.Join.Presenter>();

        builder.Services.AddApplicationLayer();

        var app = builder.Build();
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.MapControllers();
        app.Run();
    }
}