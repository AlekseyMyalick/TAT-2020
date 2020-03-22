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

        public Car(Engine engine, Chassis chassis, Transmission transmission)
        {
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

        public string GetInfo()
        {
            return $"{_engine.GetInfo()}\n" +
                $"{_chassis.GetInfo()}\n" +
                $"{_transmission.GetInfo()}\n";
        }
    }
}
