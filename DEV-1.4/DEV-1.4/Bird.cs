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

        /// <summary>
        /// constructor initializes class elements
        /// </summary>
        public Bird(Coordinate currentPosition) : base(currentPosition)
        {
        }

        /// <summary>
        /// method FlyTo checks to fly or not
        /// </summary>
        public bool FlyTo(Coordinate newCoordinate)
        {
            CheckSpeed(speed);
            float distance = CurrentPosition.DistanceBetweenPoints(newCoordinate);
            CheckDistance(distance);
            return true;
        }

        /// <summary>
        /// method GetFlyTime returns flight time
        /// </summary>
        public DateTime GetFlyTime(Coordinate newCoordinate)
        {
            float distance = CurrentPosition.DistanceBetweenPoints(newCoordinate);            
            float flyTime = distance / speed;
            DateTime time = DateTime.Now;
            return time.AddHours((double)flyTime);
        }

        /// <summary>
        /// method CheckSpeed checks speed to zero
        /// </summary>
        void CheckSpeed(int speed)
        {
            if (speed == 0)
            {
                throw new Exception("Speed is zero");
            }

        }

        /// <summary>
        /// method CheckDistance checks for maximum distance (1500)
        /// </summary>
        void CheckDistance(float distance)
        {
            if (distance > 1500)
            {
                throw new Exception("Distance is more than 1500 km");
            }

        }
    }
}
