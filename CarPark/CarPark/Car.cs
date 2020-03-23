using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark
{
    public class Car
    {
        private string _name;
        private Engine _engine;
        private Chassis _chassis;
        private Transmission _transmission;

        public Car(string name, Engine engine, Chassis chassis, Transmission transmission)
        {
            Name = name;
            EngineField = engine;
            ChassisField = chassis;
            TransmissionField = transmission;
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                CheckName(value);
                _name = value;
            }
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

        void CheckName(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (LetterCheck(value[i]) == false )
                {
                    throw new Exception("Must be letters of the latin alphabet or numbers");
                }
            }
        }

        bool LetterCheck(char symbol)
        {
            return (((int)symbol >= (char)65) && ((int)symbol <= (char)90)) ||
                (((int)symbol >= (char)97) && ((int)symbol <= (char)122)) ||
                symbol == ' ' || ((int)symbol >= (char)48) && ((int)symbol <= (char)57);
        }

        public string GetInfo()
        {
            return $"{_engine.GetInfo()}\n" +
                $"{_chassis.GetInfo()}\n" +
                $"{_transmission.GetInfo()}\n";
        }
    }
}
