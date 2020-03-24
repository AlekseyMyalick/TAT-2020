using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark
{
    public abstract class Car
    {
        private string _name;
        private Engine _engine;
        private Chassis _chassis;
        private Transmission _transmission;

        /// <summary>
        /// constructor initializes class elements
        /// </summary>
        public Car(string name, Engine engine, Chassis chassis, Transmission transmission)
        {
            Name = name;
            EngineField = engine;
            ChassisField = chassis;
            TransmissionField = transmission;
        }

        /// <summary>
        /// method Name accepts and returns values
        /// </summary>
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

        /// <summary>
        /// method EngineField accepts and returns values
        /// </summary>
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

        /// <summary>
        /// method ChassisField accepts and returns values
        /// </summary>
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

        /// <summary>
        /// method TransmissionField accepts and returns values
        /// </summary>
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

        /// <summary>
        /// method CheckName throws an error if the character does not meet the standards
        /// </summary>
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

        /// <summary>
        /// methode LetterCheck returns true or false depending on the character transmitted
        /// </summary>
        bool LetterCheck(char symbol)
        {
            return (((int)symbol >= (char)65) && ((int)symbol <= (char)90)) ||
                (((int)symbol >= (char)97) && ((int)symbol <= (char)122)) ||
                symbol == ' ' || ((int)symbol >= (char)48) && ((int)symbol <= (char)57);
        }

        /// <summary>
        /// method GetInfo returns a string with data
        /// </summary>
        public string GetInfo()
        {
            return $"{_engine.GetInfo()}\n" +
                $"{_chassis.GetInfo()}\n" +
                $"{_transmission.GetInfo()}\n";
        }
    }
}
