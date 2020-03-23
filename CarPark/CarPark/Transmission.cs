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

        /// <summary>
        /// constructor initializes class elements
        /// </summary>
        public Transmission(string type, int numberOfGears, string manufaturer)
        {
            Type = type;
            NumberOfGears = numberOfGears;
            Manufacturer = manufaturer;
        }

        /// <summary>
        /// method Type accepts and returns values
        /// </summary>
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

        /// <summary>
        /// method NumberOfGears accepts and returns values
        /// </summary>
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

        /// <summary>
        /// method Manufactirer accepts and returns values
        /// </summary>
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

        /// <summary>
        /// method FrontWheel returns line
        /// </summary>
        public static string FrontWheel
        {
            get
            {
                return "front-wheel";
            }
        }

        /// <summary>
        /// method Rear returns line
        /// </summary>
        public static string Rear
        {
            get
            {
                return "rear";
            }
        }

        /// <summary>
        /// method FourWheel returns line
        /// </summary>
        public static string FourWheel
        {
            get
            {
                return "four-wheel";
            }
        }

        /// <summary>
        /// method GetInfo returns a string with data
        /// </summary>
        public string GetInfo()
        {
            return $"TRANSMISSION \n" +
                $"Type: {_type} drive \n" +
                $"Number of gears: {_numberOfGears} \n" +
                $"Manufacturer: {_manufacturer} \n";
        }
    }
}
