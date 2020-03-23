using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark
{
    public class Truck:Car
    {
        private float _weight;
        private float _carryingCapacity;
        private float _maximumSpeed;

        public Truck(string name, float weight, float carryingCapacity, float maximumSpeed, 
            Engine engine, Chassis chassis, Transmission transmission)
            : base(name, engine, chassis, transmission)
        {
            Weight = weight;
            CarryingCapacity = carryingCapacity;
            MaximumSpeed = maximumSpeed;
        }

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

