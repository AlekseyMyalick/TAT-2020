using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1._4
{
    public class Bird:Flying, IFlyable
    {
        int speed = Randomizer.GeneratesRandomSpeed();

        public Bird(Coordinate currentPosition) : base(currentPosition)
        {
        }
        
        public bool FlyTo(Coordinate newCoordinate)
        {
            CheckSpeed(speed);
            float distance = CurrentPosition.DistanceBetweenPoints(newCoordinate);
            CheckDistance(distance);
            return true;
        } 

        public DateTime GetFlyTime(Coordinate newCoordinate)
        {
            float distance = CurrentPosition.DistanceBetweenPoints(newCoordinate);            
            float flyTime = distance / speed;
            DateTime time = DateTime.Now;
            return time.AddHours((double)flyTime);
        }

        void CheckSpeed(int speed)
        {
            if (speed == 0)
            {
                throw new Exception("Speed is zero");
            }

        }

        void CheckDistance(float distance)
        {
            if (distance > 1500)
            {
                throw new Exception("Distance is more than 1500 km");
            }

        }
    }
}
