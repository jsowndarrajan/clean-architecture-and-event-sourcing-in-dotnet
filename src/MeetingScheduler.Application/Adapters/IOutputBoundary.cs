namespace MeetingScheduler.Application.Adapters;

public interface IOutputBoundary<T>
{
    T Output { get; }

    void Populate(T response);
}