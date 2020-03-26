using System;
using System.Collections.Generic;

namespace DEV_1_2
{
    public class NumberSystem
    {
        private int _number;
        private int _numberSystem;

        /// <summary>
        /// constructor initializes class elements
        /// </summary>
        public NumberSystem(int number, int numberSystem)
        {
            Number = number;
            System = numberSystem;
        }

        /// <summary>
        /// method Number accepts and returns values
        /// </summary>
        public int Number
        {
            get
            {
                return _number;
            }

            set
            {
                CheckNumber(value);
                _number = value;
            }
        }

        /// <summary>
        /// method System accepts and returns values
        /// </summary>
        public int System
        {
            get
            {
                return _numberSystem;
            }

            set
            {
                CheckNumber(value);
                CheckSystem(value);
                _numberSystem = value;
            }
        }

        /// <summary>
        /// method TransferToNewSystem translates a number from one number system to another
        /// </summary>
        public string TransferToNewSystem()
        {
            int residue = 0;
            List<string> InverseNumber = new List<string>();

            while(Number>0){
                residue = Number % System;
                Number = Number / System;
                CheckResidue(residue, InverseNumber);
            }

            return CorrectSequence(InverseNumber);
        }

        /// <summary>
        /// methode CheckResidue checks the remainder of the division
        /// </summary>
        public List<string> CheckResidue(int residue, List<string> InverseNumber)
        {
            if (residue > 9)
            {
                InverseNumber.Add(ResiderGreaterNine(residue));
                return InverseNumber;
            }

            else
            {
                InverseNumber.Add(residue.ToString());
                return InverseNumber;
            }
        }

        /// <summary>
        /// methode CorrectSequence returns the List as a string in reverse order
        /// </summary>
        public static string CorrectSequence(List<string> InverseNumber)
        {
            List<string> Numbers = new List<string>();

            for(int i = InverseNumber.Count-1; i >= 0; i--)
            {
                Numbers.Add(InverseNumber[i]);
            }

            return string.Join(String.Empty,Numbers);
        }

        /// <summary>
        /// methode ResiderGreaterNine returns the letter to the corresponding remainder
        /// </summary>
        public static string ResiderGreaterNine(int residue)
        {
            return $"{(char)(55 + residue)}";
        }

        /// <summary>
        /// methode CheckNumber check the type of number, positive number
        /// </summary>
        void CheckNumber(int value)
        {
            if (value.GetType() != typeof(int))
            {
                throw new ArgumentOutOfRangeException();
            }

            if(value < 0)
            {
                throw new ArgumentNullException();
            }
        }

        /// <summary>
        /// methode CheckSystem checks the order of the number system
        /// </summary>
        void CheckSystem(int value)
        {
            if (value < 2)
            {
                throw new ArgumentException();
            }

            if (value > 20)
            {
                throw new Exception();
            }
        }
    }
}
