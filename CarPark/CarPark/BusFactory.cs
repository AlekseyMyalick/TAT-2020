using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark
{
    class BusFactory:IVehicleFactory
    {
        public Vehicle FactoryMethod()
        {
            Engine BusEngine = new Engine(110, 2400, Engine.Electrical, "KLUEP64501N141245");
            Chassis BusChassis = new Chassis(5, "LAUYP64GHN5141245", 3055);
            Transmission BusTransmission = new Transmission(Transmission.Rear, 9, "Ikarus USSR");
            Bus bus = new Bus("Ikarus 1980", 45, 4, BusEngine, BusChassis, BusTransmission);
            return bus;
        }
    }
}
