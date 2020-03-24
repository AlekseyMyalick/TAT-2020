using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark
{
    class Scooter:Car
    {
        private float _maximumSpeed;
        private int _numberOfSeats;

        /// <summary>
        /// constructor initializes class elements
        /// </summary>
        public Scooter(string name, float maximumSpeed, int numberOfSeats,Engine engine, 
            Chassis chassis, Transmission transmission)
            : base(name, engine, chassis, transmission)
        {
            MaximumSpeed = maximumSpeed;
            NumberOfSeats = numberOfSeats;
        }

        /// <summary>
        /// method MaximumSpeed accepts and returns values
        /// </summary>
        public float MaximumSpeed
        {
            get
            {
                return _maximumSpeed;
            }

            set
            {
                _maximumSpeed = value;
            }
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
        /// method GetInfo returns a string with data
        /// </summary>
        public string GetInfoCar()
        {
            return $"GENERAL\n" +
                $"Name: {Name} \n" +
                $"Maximum speed: {_maximumSpeed} kilometers per hour\n" +
                $"Number of seats: {_numberOfSeats}\n\n" + GetInfo();
        }
    }
}
