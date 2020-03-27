using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1._4
{
    class Bird:Flying, IFlyable
    {
        public Bird(Coordinate currentPosition) : base(currentPosition)
        {
        }

        public void FlyTo(Coordinate newCoordinate)
        {
            CurrentPosition = newCoordinate;
        } 

        public Coordinate GetFlyTime()
        {
            //FlyTo();
            /// ??????
            CurrentPosition.DistanceBetweenPoints(CurrentPosition);

        }
    }
}
