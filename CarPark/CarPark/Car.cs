using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark
{
    public class Car
    {
        private Engine _engine;
        private Chassis _chassis;
        private Transmission _transmission;
        private string _name;

        public Car(string name, Engine engine, Chassis chassis, Transmission transmission)
        {
            Name = name;
            EngineField = engine;
            ChassisField = chassis;
            TransmissionField = transmission;
        }

        public Engine EngineField
        {
            get
            {
                return _engine;
            }

            set
            {
                _engine = value;
            }
        }

        public Chassis ChassisField
        {
            get
            {
                return _chassis;
            }

            set
            {
                _chassis = value;
            }
        }

        public Transmission TransmissionField
        {
            get
            {
                return _transmission;
            }

            set
            {
                _transmission = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string GetInfo()
        {
            return $"NAME: {_name} \n\n" +
                $"{_engine.GetInfo()}\n" +
                $"{_chassis.GetInfo()}\n" +
                $"{_transmission.GetInfo()}\n";
        }
    }
}
