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
            Engine PassengerCarEngine = new Engine(120, 1598, "V6", "WAUYP64B01N141245");
            Chassis PassengerCarChassis = new Chassis(4, "JH2PC35051M200020", 2055);
            Transmission PassengerCarTransmission = new Transmission("front-wheel", 6, "PSA Peugeot Citroën");
            Car PassengerCar = new Car("Passenger car", PassengerCarEngine, PassengerCarChassis, PassengerCarTransmission);
            Console.WriteLine(PassengerCar.GetInfo());

            Console.WriteLine(PassengerCar.EngineField.GetInfo());
        }
    }
}
