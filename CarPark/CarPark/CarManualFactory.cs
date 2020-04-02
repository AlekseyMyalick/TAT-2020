using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark
{
    class CarManualFactory:IVehicleFactory
    {
        public Vehicle FactoryMethod()
        {
            Engine PassengerCarEngine = new Engine(120, 1598, Engine.Petrol, "WAUYP64B01N141245");
            Chassis PassengerCarChassis = new Chassis(4, "Z5UVP64B01N14AN45", 2055);
            Transmission PassengerCarTransmission = new Transmission(Transmission.AutomaticTransmission,
                6, "PSA Peugeot Citroën");
            PassengerCar passengerCar = new PassengerCar("Peugeot 5003", "green", 180, PassengerCarEngine,
                PassengerCarChassis, PassengerCarTransmission);
            return passengerCar;
        }
    }
}
