using System;

namespace DEV_1
{
    public class Lines 
    {
        private string _line;

        /// <summary>
        /// constructor initializes class elements
        /// </summary>
        #region Lines Сonstructor
        public Lines(string line)
        {
            Line = line;
        }
        #endregion

        /// <summary>
        /// method Line accepts and returns values
        /// </summary>
        #region Line
        public string Line
        {
            get
            {
                return _line;
            }

            set
            {
                CheckValue(value);
                _line = value.ToLower();
            }
        }
        #endregion

        /// <summary>
        /// method LineLength returns _line length
        /// </summary>
        #region LineLength
        public int LineLength
        {
            get
            {
                return Line.Length;
            }

        }
        #endregion

        /// <summary>
        /// method ComparisonOfLetter compares letters and counts the number of non-repeating
        /// </summary>
        #region ComparisonOfLetter
        public int ComparisonLetterReturnCount(int count, int i)
        {
            for (int j = i + 1; j < LineLength; j++)
            {
                if (Line[i] != Line[j])
                {
                    count++;
                    i++;
                }
                else
                {
                    break;
                }
            }

            return count;
        }
        #endregion

        /// <summary>
        /// methode Country counts the final amount
        /// </summary>
        #region Counting
        public int CountingNonRepeatingLetters()
        {
            if (isEmptyLine() == false)
            {
                int count = 0;

                for (int i = 0; i < LineLength; i++)
                {
                    int finalAmount = 1;
                    finalAmount = ComparisonLetterReturnCount(finalAmount, i);
                    count = Math.Max(finalAmount, count);
                }


                return count;
            }

            else
            {
                return 0;
            }
        }
        #endregion

        /// <summary>
        /// the method CheckValue checks the value and throws an error if it is Null
        /// </summary>
        #region CheckVakue
        public void CheckValue(object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }

        }
        #endregion

        /// <summary>
        /// thi methode isEmptyLine checks empty string or not
        /// </summary>
        #region isEmptyLine
        public bool isEmptyLine()
        {
            return Line == String.Empty;
        }
        #endregion
    }
}
