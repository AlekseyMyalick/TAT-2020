using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1._4
{
    class Drone:Flying,IFlyable
    {
        public Drone(Coordinate currentPosition):base(currentPosition)
        {
        }

        public bool FlyTo(Coordinate newCoordinate)
        {
            CurrentPosition = newCoordinate;
            return true;
        }

        public DateTime GetFlyTime(Coordinate newCoordinate)
        {
            float distance = CurrentPosition.DistanceBetweenPoints(newCoordinate);
            DateTime time = new DateTime();
            return time;
        } 
    }
}
