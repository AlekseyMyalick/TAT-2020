using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1._4
{
    public class Flying
    {
        private Coordinate _currentPosition;

        /// <summary>
        /// constructor initializes class elements
        /// </summary>
        public Flying(Coordinate currentPosition)
        {
            CurrentPosition = currentPosition;
        }

        /// <summary>
        /// method Coordinate accepts and returns values
        /// </summary>
        public Coordinate CurrentPosition
        {
            get
            {
                return _currentPosition;
            }
            set
            {
                _currentPosition = value;
            }
        }
    }
}
