using System;

namespace DegreesFeetCalculator
{
    class CelsiusFahrenheit : Converter
    {
        private const double reversTransferConstatnt = 5.0/9;
        private const double directTransferConstatnt = 9.0/5;
        private const double transferConstatnt = 32;

        /// <summary>
        /// conversion from degrees Fahrenheit to Celsius
        /// </summary>
        public override double ReverseTransfer(double symbol)
        {
            return (symbol - transferConstatnt) * reversTransferConstatnt;
        }

        /// <summary>
        /// conversion from degrees Celsius to Fahrenheit
        /// </summary>
        public override double DirectTransfer(double symbol)
        {
            return (symbol*directTransferConstatnt) + transferConstatnt;
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
