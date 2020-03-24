using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark
{
    public class Truck:Vehicle
    {
        private float _weight;
        private float _carryingCapacity;
        private float _maximumSpeed;

        /// <summary>
        /// constructor initializes class elements
        /// </summary>
        public Truck(string name, float weight, float carryingCapacity, float maximumSpeed, 
            Engine engine, Chassis chassis, Transmission transmission)
            : base(name, engine, chassis, transmission)
        {
            Weight = weight;
            CarryingCapacity = carryingCapacity;
            MaximumSpeed = maximumSpeed;
        }

        /// <summary>
        /// method Weight accepts and returns values
        /// </summary>
        public float Weight
        {
            get
            {
                return _weight;
            }

            set
            {
                _weight = value;
            }
        }

        /// <summary>
        /// method CarryingCapacity accepts and returns values
        /// </summary>
        public float CarryingCapacity
        {
            get
            {
                return _carryingCapacity;
            }

            set
            {
                _carryingCapacity = value;
            }
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
        /// method GetInfo returns a string with data
        /// </summary>
        public string GetInfoCar()
        {
            return $"GENERAL\n" +
                $"Name: {Name} \n" +
                $"Weight: {_weight} kilograms\n" +
                $"Carrying capacity: {_carryingCapacity} kilograms\n" +
                $"Maximum speed: {_maximumSpeed} kilometers per hour\n\n" + GetInfo();
        }
    }
}

