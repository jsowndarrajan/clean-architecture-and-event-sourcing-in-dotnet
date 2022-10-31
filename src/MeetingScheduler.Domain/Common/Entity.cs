namespace MeetingScheduler.Domain.Common;

public class Entity : IEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();
}