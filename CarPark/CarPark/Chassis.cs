using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark
{
    public class Chassis
    {
        private int _numberOfWheels;
        private string _serialNumber;
        private float _permissibleLoad;

        public Chassis(int numberOfWheels, string serialNumbers, float permissibleLoad)
        {
            NumberOfWheels = numberOfWheels;
            SerialNumber = serialNumbers;
            PermissibleLoad = permissibleLoad;
        }

        public int NumberOfWheels
        {
            get
            {
                return _numberOfWheels;
            }

            set
            {
                CheckWheels(value);
                _numberOfWheels = value;
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

        public float PermissibleLoad
        {
            get
            {
                return _permissibleLoad;
            }

            set
            {
                _permissibleLoad = value;
            }
        }

        void CheckWheels(int value)
        {
            if (value < 0)
            {
                throw new Exception("the number of wheels cannot be less than zero");
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
            return $"CHASSIS \n" +
                $"Number of wheels: {_numberOfWheels} \n" +
                $"Serial number: {_serialNumber}\n" +
                $"Permissible load: {_permissibleLoad} kilogram \n";
        }

    }
}
