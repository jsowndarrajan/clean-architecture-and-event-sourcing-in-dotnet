using MeetingScheduler.Domain.Common;

namespace MeetingScheduler.Domain.Gateways;

public interface IEventStore
{
    void Save(IDomainEvent domainEvent);
    IEnumerable<IDomainEvent> FetchBy(Guid aggregateRootId);
}