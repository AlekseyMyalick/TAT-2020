using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark
{
    class TrackManualTransmissionFactory:IVehicleFactory
    {
        public Vehicle FactoryMethod()
        {
            Engine TruckEngine = new Engine(400, 3256, Engine.Diesel, "QAUYP64B15NAD1245");
            Chassis TruckChassis = new Chassis(6, "FNDYP64B01K141245", 5000);
            Transmission TruckTransmission = new Transmission(Transmission.ManualTransmission, 9,
                " Fiat Chrysler Automobiles");
            Truck truck = new Truck("Fiat Chrysler S800", 5200, 7500, 160,
                TruckEngine, TruckChassis, TruckTransmission);
            return truck;
        }
    }
}
