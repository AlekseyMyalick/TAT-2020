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
            List<Vehicle> vehicles = new List<Vehicle>();
            var carAutoPetrol = new CarPetrolFactory();
            var carManual = new CarManualFactory();
            var bus45Seats = new BusFactory();
            var truckAuto = new TrackManualTransmissionFactory();
            vehicles.Add(carAutoPetrol.FactoryMethod());
            vehicles.Add(carAutoPetrol.FactoryMethod());
            vehicles.Add(carManual.FactoryMethod());
            vehicles.Add(carManual.FactoryMethod());
            vehicles.Add(carManual.FactoryMethod());
            vehicles.Add(truckAuto.FactoryMethod());
            vehicles.Add(bus45Seats.FactoryMethod());
        }
    }
}
