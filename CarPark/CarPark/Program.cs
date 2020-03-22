using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine PassengerCarEngine = new Engine(120, 1598, "gas", "WAUYP64B01N141245");
            Chassis PassengerCarChassis = new Chassis(4, "JH2PC35051M200020", 2055);
            Transmission PassengerCarTransmission = new Transmission("front-wheel", 6, "PSA Peugeot Citroën");
            PassengerCar passengerCar = new PassengerCar("Peugeot 5003", "green", 180, PassengerCarEngine,
                PassengerCarChassis, PassengerCarTransmission);
            Console.WriteLine(passengerCar.GetInfoCar());

            Engine TruckEngine = new Engine(400, 3256, "diesel", "DFN1866DGFR684VF6MD");
            Chassis TruckChassis = new Chassis(6, "FBKNLKTB55RTGLK5566", 5000);
            Transmission TruckTransmission = new Transmission("rear wheel drive", 9, " Fiat Chrysler Automobiles");
            Truck truck = new Truck(5200, 7500, 160, TruckEngine, TruckChassis, TruckTransmission);
            Console.WriteLine(truck.GetInfoCar());

            Engine BusEngine = new Engine(110, 2400, "gas", "WAUFGBGF5441245");
            Chassis BusChassis = new Chassis(5, "JH2PC35051M200020", 3055);
            Transmission BusTransmission = new Transmission("rear wheel drive", 9, "Ikarus USSR");
            Bus bus = new Bus("Ikarus", 24, 4, BusEngine, BusChassis, BusTransmission);
            Console.WriteLine(bus.GetInfoCar());

            Engine ScooterEngine = new Engine(70, 1000, "gas", "QAUFGBGSDF5445");
            Chassis ScooterChassis = new Chassis(2, "BGRBF4685DFV", 90);
            Transmission ScooterTransmission = new Transmission("front-wheel", 2, "ABM Storm SL");
            Scooter scooter = new Scooter(80, 2, ScooterEngine, ScooterChassis, ScooterTransmission);
            Console.WriteLine(scooter.GetInfoCar());
        }
    }
}
