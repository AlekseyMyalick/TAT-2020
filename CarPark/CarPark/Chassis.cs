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

        /// <summary>
        /// constructor initializes class elements
        /// </summary>
        public Chassis(int numberOfWheels, string serialNumbers, float permissibleLoad)
        {
            NumberOfWheels = numberOfWheels;
            SerialNumber = serialNumbers;
            PermissibleLoad = permissibleLoad;
        }

        /// <summary>
        /// method NumberOfWheels accepts and returns values
        /// </summary>
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
        /// method PermissibkeLoad accepts and returns values
        /// </summary>
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

        /// <summary>
        /// methode CheckWheels throws an error if the value is less than zero
        /// </summary>
        void CheckWheels(int value)
        {
            if (value < 0)
            {
                throw new Exception("the number of wheels cannot be less than zero");
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
            return $"CHASSIS \n" +
                $"Number of wheels: {_numberOfWheels} \n" +
                $"Serial number: {_serialNumber}\n" +
                $"Permissible load: {_permissibleLoad} kilogram \n";
        }

    }
}
