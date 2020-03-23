using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark
{
    public class Engine
    {
        private float _power;
        private float _capacity;
        private string _type;
        private string _serialNumber;

        /// <summary>
        /// constructor initializes class elements
        /// </summary>
        public Engine(float power, float capacity, string type, string serialNumber)
        {
            Power = power;
            Capacity = capacity;
            Type = type;
            SerialNumber = serialNumber;
        }

        /// <summary>
        /// method Power accepts and returns values
        /// </summary>
        public float Power
        {
            get
            {
                return _power;
            }

            set
            {
                _power = value;
            }
        }

        /// <summary>
        /// method Capasity accepts and returns values
        /// </summary>
        public float Capacity
        {
            get
            {
                return _capacity;
            }

            set
            {
                _capacity = value;
            }
        }

        /// <summary>
        /// method Type accepts and returns values
        /// </summary>
        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }

        /// <summary>
        /// method SerialNumber accepts and returns values
        /// </summary>
        public string SerialNumber
        {
            get
            {
                return _serialNumber;
            }

            set
            {
                CheckSerialNumber(value);
                LatinCheck(value);
                _serialNumber = value;
            }
        }

        /// <summary>
        /// method Gas returns line
        /// </summary>
        public static string Gas
        {
            get
            {
                return "gas";
            }
        }

        /// <summary>
        /// method Diesel returns line
        /// </summary>
        public static string Diesel
        {
            get
            {
                return "diesel";
            }
        }

        /// <summary>
        /// method Electrical returns line
        /// </summary>
        public static string Electrical
        {
            get
            {
                return "electrical";
            }
        }

        /// <summary>
        /// methode CheckSerialNumber throws an error if the value not equal to 17
        /// </summary>
        void CheckSerialNumber(string value)
        {
            if (value.Length != 17)
            {
                throw new Exception("number of characters must be equal to 17");
            }
        }

        /// <summary>
        /// methode LatinCheck throws an error if the character does not meet the standards
        /// </summary>
        void LatinCheck(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (!(Char.IsDigit(value[i]) || value[i] >= 'A' && value[i] <= 'Z'))
                {
                    throw new Exception("Must be capital letters of the latin alphabet");
                }
            }
        }

        /// <summary>
        /// method GetInfo returns a string with data
        /// </summary>
        public string GetInfo()
        {
            return $"ENGINE \n" +
                $"Power: {_power} horsepower \n" +
                $"Capacity: {_capacity} centimeters cubic \n" +
                $"Type: {_type} \n" +
                $"Serial number: {_serialNumber} \n";
        }
    }
}
