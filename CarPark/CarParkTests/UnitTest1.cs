using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CarParkTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CheckSerialNumberEngine_FewerCharacters()
        {
            CarPark.Engine engine = new CarPark.Engine(120, 1598, CarPark.Engine.Gas, "WAUYP64B01N14124");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CheckSerialNumberEngine_SmallLetter()
        {
            CarPark.Engine engine = new CarPark.Engine(120, 1598, CarPark.Engine.Gas, "WAuYP64B01N141245");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CheckSerialNumberEngine_DifferentСharacter()
        {
            CarPark.Engine engine = new CarPark.Engine(120, 1598, CarPark.Engine.Gas, "WAUYP64#01N141245");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CheckSerialNumberChassis_FewerCharacters()
        {
            CarPark.Chassis PassengerCarChassis = new CarPark.Chassis(4, "Z5UVP64B1N14AN45", 2055);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CheckSerialNumberChassis_SmallLetter()
        {
            CarPark.Chassis PassengerCarChassis = new CarPark.Chassis(4, "Z5UVP64b1N14AN45", 2055);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CheckSerialNumberChassis_DifferentСharacter()
        {
            CarPark.Chassis PassengerCarChassis = new CarPark.Chassis(4, "Z5U&P64b1N14AN45", 2055);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CheckNumberWheels()
        {
            CarPark.Chassis PassengerCarChassis = new CarPark.Chassis(-1, "Z5U1P64b1N14AN45", 2055);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("пежо")]
        [DataRow("Pege#ot")]
        [ExpectedException(typeof(Exception))]
        public void CheckNameCar(string name)
        {
            CarPark.Engine PassengerCarEngine = new CarPark.Engine(120, 1598, CarPark.Engine.Gas, "WAUYP64B01N141245");
            CarPark.Chassis PassengerCarChassis = new CarPark.Chassis(4, "Z5UVP64B01N14AN45", 2055);
            CarPark.Transmission PassengerCarTransmission = new CarPark.Transmission(CarPark.Transmission.FrontWheel, 6,
                "PSA Peugeot Citroën");
            CarPark.PassengerCar passengerCar = new CarPark.PassengerCar(name, "green", 180, PassengerCarEngine,
                PassengerCarChassis, PassengerCarTransmission);


        }
    }
}
