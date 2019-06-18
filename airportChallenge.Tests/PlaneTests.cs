using NUnit.Framework;
using airportChallenge;

namespace airportChallenge.UnitTests
{
    [TestFixture]
    public class PlaneTests
    {
        private Plane _plane;

        [SetUp]
        public void Init()
        {
            _plane = new Plane();
        }

        [Test]
        [Ignore("Awaiting plane implementation")]
        public void ReturnsInstanceOf()
        {
            Assert.IsInstanceOf(typeof(Plane), _plane);
        }
    }
}