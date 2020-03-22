﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark
{
    public class Bus:Car
    {
        private int _numberOfSeats;
        private int _numberOfDoors;
        private string _name;

        public Bus(string name, int numberOfSeats, int numberOfDoors,
            Engine engine, Chassis chassis, Transmission transmission)
            : base(engine, chassis, transmission)
        {
            NumberOfSeats = numberOfSeats;
            NumberOfDoors = numberOfDoors;
            Name = name;
        }

        public int NumberOfSeats
        {
            get
            {
                return _numberOfSeats;
            }

            set
            {
                _numberOfSeats = value;
            }
        }

        private int NumberOfDoors
        {
            get
            {
                return _numberOfDoors;
            }

            set
            {
                _numberOfDoors = value;
            }
        }

        private string Name
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

        public string GetInfoCar()
        {
            return $"GENERAL\n" +
                $"Name {_name}\n" +
                $"Number of doors: {_numberOfDoors}\n" +
                $"Number of seats: {_numberOfSeats}\n\n" + GetInfo();
        }
    }
}
