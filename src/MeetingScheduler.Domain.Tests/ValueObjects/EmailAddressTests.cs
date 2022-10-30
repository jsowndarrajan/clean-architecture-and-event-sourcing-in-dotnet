using FluentAssertions;
using FluentAssertions.Common;
using MeetingScheduler.Domain.ValueObjects;

namespace MeetingScheduler.Domain.Tests.ValueObjects;

[TestFixture]
public class EmailAddressTests
{
    [TestFixture]
    public class GivenValidEmailAddress
    {
        [Test]
        public void ImplicitOperatorShouldInitializeTheEmailAddress()
        {
            EmailAddress givenAddress = "test@test.com";

            givenAddress.Value.Should().Be("test@test.com");
        }
    }

    [TestFixture]
    public class GivenInvalidEmailAddress
    {
        [Test]
        public void ImplicitOperatorShouldInitializeTheEmailAddress()
        {
            var action = () =>
            {
                var email = new EmailAddress("test.com");
            };

            action.Should().Throw<EmailAddressInvalidException>()
                .And
                .BusinessMessage.Should().Be("Email Address is invalid");
        }
    }
}