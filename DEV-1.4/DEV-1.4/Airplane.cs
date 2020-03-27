using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1._4
{
    class Airplane:Flying, IFlyable
    {
        public Airplane(Coordinate currentPosition) : base(currentPosition)
        {
        }

        public void FlyTo(Coordinate newCoordinate)
        {
            CurrentPosition = newCoordinate;
        }

        public Coordinate GetFlyTime()
        {

        }
    }
}
