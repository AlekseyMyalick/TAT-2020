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
            Engine PassengerCarEngine = new Engine(120, 1598, Engine.Gas, "WAUYP64B01N141245");
            Chassis PassengerCarChassis = new Chassis(4, "Z5UVP64B01N14AN45", 2055);
            Transmission PassengerCarTransmission = new Transmission(Transmission.FrontWheel, 6,
                "PSA Peugeot Citroën");
            PassengerCar passengerCar = new PassengerCar("Peugeot 5003", "green", 180, PassengerCarEngine,
                PassengerCarChassis, PassengerCarTransmission);
            Console.WriteLine(passengerCar.GetInfoCar());

            Engine TruckEngine = new Engine(400, 3256, Engine.Diesel, "QAUYP64B15NAD1245");
            Chassis TruckChassis = new Chassis(6, "FNDYP64B01K141245", 5000);
            Transmission TruckTransmission = new Transmission(Transmission.FourWheel, 9, 
                " Fiat Chrysler Automobiles");
            Truck truck = new Truck("Fiat Chrysler S800", 5200, 7500, 160, 
                TruckEngine, TruckChassis, TruckTransmission);
            Console.WriteLine(truck.GetInfoCar());

            Engine BusEngine = new Engine(110, 2400, Engine.Electrical, "KLUEP64501N141245");
            Chassis BusChassis = new Chassis(5, "LAUYP64GHN5141245", 3055);
            Transmission BusTransmission = new Transmission(Transmission.Rear, 9, "Ikarus USSR");
            Bus bus = new Bus("Ikarus 1980", 24, 4, BusEngine, BusChassis, BusTransmission);
            Console.WriteLine(bus.GetInfoCar());

            Engine ScooterEngine = new Engine(70, 1000, Engine.Electrical, "ERTYP64B01N147895");
            Chassis ScooterChassis = new Chassis(2, "MYHYP87B01N141247", 90);
            Transmission ScooterTransmission = new Transmission(Transmission.FourWheel, 2, 
                "ABM Storm SL");
            Scooter scooter = new Scooter("Honda Dio AF34", 80, 2, ScooterEngine, ScooterChassis, ScooterTransmission);
            Console.WriteLine(scooter.GetInfoCar());
        }
    }
}
