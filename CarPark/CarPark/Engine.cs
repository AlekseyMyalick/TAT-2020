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

        public Engine(float power, float capacity, string type, string serialNumber)
        {
            Power = power;
            Capacity = capacity;
            Type = type;
            SerialNumber = serialNumber;
        }

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

        public static string Gas
        {
            get
            {
                return "gas";
            }
        }

        public static string Diesel
        {
            get
            {
                return "diesel";
            }
        }

        public static string Electrical
        {
            get
            {
                return "electrical";
            }
        }

        void CheckSerialNumber(string value)
        {
            if (value.Length != 17)
            {
                throw new Exception("number of characters must be equal to 17");
            }
        }

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
