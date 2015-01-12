using FluentAssertions;
using NUnit.Framework;

namespace Rnsx.Stockify.Business.UnitTests
{
    [TestFixture]
    public class ValidatorTests
    {
        [Test]
        public void IsValid_WhenCalled_ReturnsTrue()    
        {
            Validator validator = new Validator();

            bool expected = validator.IsValid();

            expected.Should().BeTrue();
        }
    }
}
