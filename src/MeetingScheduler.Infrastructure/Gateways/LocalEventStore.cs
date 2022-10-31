using MeetingScheduler.Domain.Common;
using MeetingScheduler.Domain.Gateways;

namespace MeetingScheduler.Infrastructure.Gateways;

public class LocalEventStore : IEventStore
{
    private readonly Dictionary<Guid, List<IDomainEvent>> _events;

    public LocalEventStore()
    {
        _events = new Dictionary<Guid, List<IDomainEvent>>();
    }

    public void Save(IDomainEvent domainEvent)
    {
        if (_events.ContainsKey(domainEvent.AggregateRootId))
        {
            _events[domainEvent.AggregateRootId].Add(domainEvent);
            return;
        }
        _events.Add(domainEvent.AggregateRootId, new List<IDomainEvent> { domainEvent });
    }

    public IEnumerable<IDomainEvent> FetchBy(Guid aggregateRootId)
    {
        if (_events.ContainsKey(aggregateRootId))
        {
            return _events[aggregateRootId];
        }
        return Enumerable.Empty<IDomainEvent>();
    }
}