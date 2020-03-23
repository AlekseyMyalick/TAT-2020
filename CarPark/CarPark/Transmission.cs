using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark
{
    public class Transmission
    {
        private string _type;
        private int _numberOfGears;
        private string _manufacturer;

        public Transmission(string type, int numberOfGears, string manufaturer)
        {
            Type = type;
            NumberOfGears = numberOfGears;
            Manufacturer = manufaturer;
        }

        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }

        public int NumberOfGears
        {
            get
            {
                return _numberOfGears;
            }

            set
            {
                _numberOfGears = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return _manufacturer;
            }

            set
            {
                _manufacturer = value;
            }
        }

        public static string FrontWheel
        {
            get
            {
                return "front-wheel";
            }
        }

        public static string Rear
        {
            get
            {
                return "rear";
            }
        }

        public static string FourWheel
        {
            get
            {
                return "four-wheel";
            }
        }

        public string GetInfo()
        {
            return $"TRANSMISSION \n" +
                $"Type: {_type} drive \n" +
                $"Number of gears: {_numberOfGears} \n" +
                $"Manufacturer: {_manufacturer} \n";
        }
    }
}
