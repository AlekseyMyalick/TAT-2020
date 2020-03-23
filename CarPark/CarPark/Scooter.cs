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

        public Scooter(string name, float maximumSpeed, int numberOfSeats,Engine engine, Chassis chassis, Transmission transmission)
            : base(name, engine, chassis, transmission)
        {
            MaximumSpeed = maximumSpeed;
            NumberOfSeats = numberOfSeats;
        }

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

        public string GetInfoCar()
        {
            return $"GENERAL\n" +
                $"Name: {Name} \n" +
                $"Maximum speed: {_maximumSpeed} kilometers per hour\n" +
                $"Number of seats: {_numberOfSeats}\n\n" + GetInfo();
        }
    }
}
