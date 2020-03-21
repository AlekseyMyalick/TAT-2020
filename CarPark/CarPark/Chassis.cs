﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark
{
    public class Chassis
    {
        private float _numberOfWheels;
        private string _serialNumber;
        private float _permissibleLoad;

        public Chassis(float numberOfWheels, string serialNumbers, float permissibleLoad)
        {
            NumberOfWheels = numberOfWheels;
            SerialNumber = serialNumbers;
            PermissibleLoad = permissibleLoad;
        }

        public float NumberOfWheels
        {
            get
            {
                return _numberOfWheels;
            }

            set
            {
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

        public string GetInfo()
        {
            return $"CHASSIS \n" +
                $"Number of wheels: {_numberOfWheels} \n" +
                $"Serial number: {_serialNumber}\n" +
                $"Permissible load: {_permissibleLoad} kilogram \n";
        }

    }
}
