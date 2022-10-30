using FluentAssertions;
using MeetingScheduler.Domain.ValueObjects;

namespace MeetingScheduler.Domain.Tests.ValueObjects;

[TestFixture]
public class TimeRangeTests
{
    [TestFixture]
    public class GivenStartTimeIsLessThanEndTime
    {
        private TimeRange _sut;

        [SetUp]
        public void SetUp()
        {
            var startTime = new DateTime(2022, 11, 01, 14, 30, 00);
            var endTime = new DateTime(2022, 11, 01, 15, 30, 00);
            _sut = new TimeRange(startTime, endTime);
        }

        [Test]
        public void TimeDurationShouldBeEqualToTheTimeDifferenceBetweenStartAndEndTime()
        {
            var meetingDuration = _sut.Duration;

            meetingDuration.Should().Be(new TimeSpan(1, 0, 0));
        }

        [Test]
        public void StringConversionShouldReturnExactStartAndEndTime()
        {
            var meeting = _sut.ToString();

            meeting.Should().Be("Start: 2022-11-01 14:30 End: 2022-11-01 15:30");
        }
    }

    [TestFixture]
    public class GivenStartTimeIsGreaterThanEndTime
    {
        [Test]
        public void ThrowDomainExceptionWithExpectedMessage()
        {
            var startTime = DateTime.Now;
            var endTime = startTime.AddHours(-1);

            var action = () =>
            {
                var timeRange = new TimeRange(startTime, endTime);
            };

            action.Should().Throw<TimeRangeInvalidException>()
                .And
                .BusinessMessage.Should().Be("The start time should be less than the end time");
        }
    }
}