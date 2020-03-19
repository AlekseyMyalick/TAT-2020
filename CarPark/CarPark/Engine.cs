using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark
{
    class Engine
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
                _serialNumber = value;
            }
        }
    }
}
