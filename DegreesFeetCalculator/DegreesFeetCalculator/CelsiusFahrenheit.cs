using System;

namespace DegreesFeetCalculator
{
    class CelsiusFahrenheit : Converter
    {
        /// <summary>
        /// conversion from degrees Fahrenheit to Celsius
        /// </summary>
        public override double ReverseTransfer(double symbol)
        {
            return (5 * (symbol - 32)) / 9;
        }

        /// <summary>
        /// conversion from degrees Celsius to Fahrenheit
        /// </summary>
        public override double DirectTransfer(double symbol)
        {
            return ((9 * symbol) / 5) + 32;
        }

        /// <summary>
        /// returns value depending on the selected transfer
        /// </summary>
        public override double Convert(double temperature, string convertName)
        {
           if(convertName == "FC")
            {
                return ReverseTransfer(temperature);
            }

           else if (convertName == "CF")
            {
                return DirectTransfer(temperature);
            }

            throw new ArgumentException("Invalid arguments entered");
        }
    }
}
