namespace MeetingScheduler.Application.Adapters;

public interface IInputBoundary<in T>
{
    Task Process(T request);
}