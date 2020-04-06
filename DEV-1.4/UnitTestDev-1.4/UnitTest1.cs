using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DEV_1._4;

namespace UnitTestDev_1._4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DistanceBetweenPointsTests()
        {
            Coordinate coordinate1 = new Coordinate(1, 1, 1);
            Coordinate coordinate2 = new Coordinate(2, 2, 2);
            float actual = coordinate1.DistanceBetweenPoints(coordinate2);
            float expected = (float)Math.Sqrt(3);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(1, 1, -1)]
        [DataRow(-1, 1, 1)]
        [DataRow(1, -1, 1)]
        [ExpectedException(typeof(Exception))]
        public void CheckValue_Exception(float x, float y, float z)
        {
            Coordinate coordinate = new Coordinate(x, y, z);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CheckBirdDistance_FlyTo()
        {
            Coordinate coordinate1 = new Coordinate(1, 1, 1);
            Coordinate coordinate2 = new Coordinate(10000, 10000, 10000);
            Bird bird = new Bird(coordinate1);
            bird.FlyTo(coordinate2);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CheckBirdDistance_GetFlyTime()
        {
            Coordinate coordinate1 = new Coordinate(1, 1, 1);
            Coordinate coordinate2 = new Coordinate(10000, 10000, 10000);
            Bird bird = new Bird(coordinate1);
            bird.GetFlyTime(coordinate2);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CheckDroneDistance_GetFlyTime()
        {
            Coordinate coordinate1 = new Coordinate(1, 1, 1);
            Coordinate coordinate2 = new Coordinate(10000, 10000, 10000);
            Drone drone = new Drone(coordinate1);
            drone.GetFlyTime(coordinate2);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CheckDroneDistance_FlyTo()
        {
            Coordinate coordinate1 = new Coordinate(1, 1, 1);
            Coordinate coordinate2 = new Coordinate(10000, 10000, 10000);
            Drone drone = new Drone(coordinate1);
            drone.FlyTo(coordinate2);
        }
    }
}
