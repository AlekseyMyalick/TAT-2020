using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark
{
    public class PassengerCar:Car
    {
        private string _color;
        private float _maximumSpeed;

        public PassengerCar(string name, string color, float maximumSpeed, Engine engine, Chassis chassis, Transmission transmission)
            :base(name, engine, chassis, transmission)
        {
            Color = color;
            MaximumSpeed = maximumSpeed;
        }

        public string Color
        {
            get
            {
                return _color;
            }

            set
            {
                _color = value;
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
                $"Color: {_color}\n" +
                $"Maximum speed: {_maximumSpeed} kilometers per hour\n\n" + GetInfo();
        }
    }
}
