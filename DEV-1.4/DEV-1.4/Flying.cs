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


        public Flying(Coordinate currentPosition)
        {
            CurrentPosition = currentPosition;
        }

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
