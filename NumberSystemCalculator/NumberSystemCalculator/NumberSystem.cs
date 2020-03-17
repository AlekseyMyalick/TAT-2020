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
        #region NumberSystem Constructor
        public NumberSystem(int number, int numberSystem)
        {
            Number = number;
            System = numberSystem;
        }
        #endregion

        /// <summary>
        /// method Number accepts and returns values
        /// </summary>
        #region Number
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
        #endregion

        /// <summary>
        /// method System accepts and returns values
        /// </summary>
        #region System
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
        #endregion

        /// <summary>
        /// method TransferToNewSystem translates a number from one number system to another
        /// </summary>
        #region TransferToNewSystem
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
        #endregion

        /// <summary>
        /// methode CheckResidue checks the remainder of the division
        /// </summary>
        #region CheckResidue
        public List<string> CheckResidue(int residue, List<string> InverseNumber)
        {
            if (residue > 9)
            {
                InverseNumber.Add(ResiderGreaterNine(residue.ToString()));
                return InverseNumber;
            }

            else
            {
                InverseNumber.Add(residue.ToString());
                return InverseNumber;
            }
        }
        #endregion

        /// <summary>
        /// methode CorrectSequence returns the List as a string in reverse order
        /// </summary>
        #region CorrectSequence
        public static string CorrectSequence(List<string> InverseNumber)
        {
            List<string> Numbers = new List<string>();

            for(int i = InverseNumber.Count-1; i >= 0; i--)
            {
                Numbers.Add(InverseNumber[i]);
            }

            return string.Join(String.Empty,Numbers);
        }
        #endregion

        /// <summary>
        /// methode ResiderGreaterNine returns the letter to the corresponding remainder
        /// </summary>
        #region ResiderGreaterNine
        public static string ResiderGreaterNine(string residue)
        {
            switch (residue)
            {
                case "10":
                    return "A";
                case "11":
                    return "B";
                case "12":
                    return "C";
                case "13":
                    return "D";
                case "14":
                    return "E";
                case "15":
                    return "F";
                case "16":
                    return "G";
                case "17":
                    return "H";
                case "18":
                    return "I";
                case "19":
                    return "J";
            }

            return String.Empty;
        }
        #endregion

        /// <summary>
        /// methode CheckNumber check the type of number, positive number
        /// </summary>
        #region CheckNumber
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
        #endregion

        /// <summary>
        /// methode CheckSystem checks the order of the number system
        /// </summary>
        #region CheckSystem
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
        #endregion
    }
}
