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
        public void PlaneReturnsInstanceOfPlane()
        {
            Assert.IsInstanceOf(typeof(Plane), _plane);
        }

        [Test]
        public void PlaneCanRespondToFlying()
        {
            //arange
            var type = _plane.GetType();
            //act

            //assert
            Assert.IsTrue(type.GetMethod("IsFlying") != null);
        }

    }
}