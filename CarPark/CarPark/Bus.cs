using System;
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

        /// <summary>
        /// constructor initializes class elements
        /// </summary>
        public Bus(string name, int numberOfSeats, int numberOfDoors,
            Engine engine, Chassis chassis, Transmission transmission) 
            : base(name, engine, chassis, transmission)
        {
            NumberOfSeats = numberOfSeats;
            NumberOfDoors = numberOfDoors;
        }

        /// <summary>
        /// method NumberOfSeats accepts and returns values
        /// </summary>
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

        /// <summary>
        /// method NumberOfDoors accepts and returns values
        /// </summary>
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

        /// <summary>
        /// method GetInfoCar returns a string with data
        /// </summary>
        public string GetInfoCar()
        {
            return $"GENERAL\n" +
                $"Name: {Name} \n" +
                $"Number of doors: {_numberOfDoors}\n" +
                $"Number of seats: {_numberOfSeats}\n\n" + GetInfo();
        }
    }
}
