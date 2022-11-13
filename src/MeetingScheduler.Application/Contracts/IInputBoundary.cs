namespace MeetingScheduler.Application.Contracts;

public interface IInputBoundary<in T>
{
    Task Process(T request);
}