using FluentAssertions;
using MeetingScheduler.Domain.Meetings.Events;
using MeetingScheduler.Domain.ValueObjects;
using MeetingScheduler.Infrastructure.Gateways;

namespace MeetingScheduler.Infrastructure.Tests.EventStore;

[TestFixture]
public class LocalEventStoreTests
{
    private LocalEventStore _localEventStore;

    [SetUp]
    public void SetUp()
    {
        _localEventStore = new LocalEventStore();
    }

    [Test]
    public void SavedDomainEventShouldBeReturnedForValidAggregateId()
    {
        var aggregateRootId = Guid.NewGuid();
        var domainEvent = new MeetingScheduledEvent(
            aggregateRootId,
            0,
            "Tech Talks",
            new TimeRange(DateTime.Now, DateTime.Now.AddHours(1)),
            new EmailAddress[] { "test1@test.com", "test2@test.com" },
            "organizer@test.com");

        _localEventStore.Save(domainEvent);

        var actualDomainEvent = _localEventStore.FetchBy(aggregateRootId);

        actualDomainEvent.Should()
            .HaveCount(1)
            .And
            .Contain(domainEvent);
    }

    [Test]
    public void DomainEventsShouldBeEmptyForInvalidAggregateId()
    {
        var aggregateRootId = Guid.NewGuid();
        var actualDomainEvent = _localEventStore.FetchBy(aggregateRootId);

        actualDomainEvent.Should().BeEmpty();
    }

    [Test]
    public void DomainEventShouldBeAppendedWhileSavingDomainEventWithTheExistingAggregateRootId()
    {
        var aggregateRootId = Guid.NewGuid();
        var scheduledEvent = new MeetingScheduledEvent(
            aggregateRootId,
            0,
            "Tech Talks",
            new TimeRange(DateTime.Now, DateTime.Now.AddHours(1)),
            new EmailAddress[] { "test1@test.com", "test2@test.com" },
            "organizer@test.com");
        var startedEvent = new MeetingStartedEvent(
            aggregateRootId,
            1,
            "organizer@test.com");

        _localEventStore.Save(scheduledEvent);
        _localEventStore.Save(startedEvent);

        var domainEvents = _localEventStore.FetchBy(aggregateRootId);

        domainEvents.Should()
            .HaveCount(2)
            .And
            .ContainInConsecutiveOrder(scheduledEvent, startedEvent);
    }
}