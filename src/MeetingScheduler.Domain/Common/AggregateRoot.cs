namespace MeetingScheduler.Domain.Common;

public abstract class AggregateRoot : Entity, IAggregateRoot
{
    private readonly Dictionary<Type, Action<object>> _handlers;
    private readonly List<IDomainEvent> _domainEvents;

    public long Version { get; protected set; }

    protected AggregateRoot()
    {
        _handlers = new Dictionary<Type, Action<object>>();
        _domainEvents = new List<IDomainEvent>();
        Version = 0;
    }

    protected void Register<T>(Action<T> action)
    {
        _handlers.Add(typeof(T), e => action((T)e));
    }

    protected void Raise(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
        _handlers[domainEvent.GetType()](domainEvent);
        Version++;
    }

    public IReadOnlyCollection<IDomainEvent> GetEvents()
    {
        return _domainEvents;
    }

    public void Apply(IDomainEvent domainEvent)
    {
        _handlers[domainEvent.GetType()](domainEvent);
        Version++;
    }
}