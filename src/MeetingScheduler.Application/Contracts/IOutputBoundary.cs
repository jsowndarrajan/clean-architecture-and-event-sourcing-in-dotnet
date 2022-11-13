namespace MeetingScheduler.Application.Contracts;

public interface IOutputBoundary<T>
{
    T Output { get; }

    void Populate(T response);
}