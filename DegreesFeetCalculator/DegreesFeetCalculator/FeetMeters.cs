using System;

namespace DegreesFeetCalculator
{
    class FeetMeters : Converter
    {
        private const double transferConstatnt = 0.3048;

        /// <summary>
        /// conversion from Meeters to Feet 
        /// </summary>
        public override double ReverseTransfer(double symbol)
        {
            return symbol / transferConstatnt;
        }

        /// <summary>
        /// conversion from Feet to Meeters
        /// </summary>
        public override double DirectTransfer(double symbol)
        {
            return symbol * transferConstatnt;
        }

        /// <summary>
        /// returns value depending on the selected transfer
        /// </summary>
        public override double Convert(double length, string convertName)
        {
            CheckLength(length);

            if (convertName == "FM")
            {
                return DirectTransfer(length);
            }

            else if (convertName == "MF")
            {
                return ReverseTransfer(length);
            }

            throw new ArgumentException("Invalid arguments entered");
        }

        /// <summary>
        /// checks for negative length
        /// </summary>
        public void  CheckLength(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Length less then zero");
            }
        }
    }
}
