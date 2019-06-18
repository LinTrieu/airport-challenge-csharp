using NUnit.Framework;
using airportChallenge;
using Moq;

namespace airportChallenge.UnitTests
{
    [TestFixture]
    public class AirportTests
    {
        private Airport _airport; Mock<Plane> _plane;

        [SetUp]
        public void Init()
        {
            _airport = new Airport();
            _plane = new Mock<Plane>();
        }

        [Test]
        public void ReturnsInstanceOfAirport()
        {
            Assert.IsInstanceOf(typeof(Airport), _airport);
        }

        [Test]
        public void ReturnsValueOfCapacity()
        {
            _airport = new Airport(20);
            Assert.AreEqual(20, _airport.Capacity);
        }

        [Test]
        public void HasADefaultCapacity()
        {
            Assert.AreEqual(10, _airport.Capacity);
        }

        [Test]
       public void HasAHanger()
       {
           Assert.AreEqual(0, _airport.Hanger.Count);
       }

       [Test]
       public void PlaneCanLandInHanger()
       {
           _airport.Land(_plane);
           Assert.AreEqual(1, _airport.Hanger.Count);
       }

       [Test]
       public void PlaneIsInHanger()
       {
           _airport.Land(_plane);
           CollectionAssert.Contains(_airport.Hanger, _plane);
       }

       [Test]
       public void CanRespondToLand()
       {
           var type =_airport.GetType();
           Assert.IsTrue(type.GetMethod("Land") != null);
       }
    }
}