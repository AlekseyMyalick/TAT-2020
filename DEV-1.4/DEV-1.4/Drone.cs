using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1._4
{
    class Drone:Flying,IFlyable
    {
        public const double _speed = 15;
        public const double _stopPeriod = 1 / 6;
        public const double _stopTime = 1 / 60;

        /// <summary>
        /// constructor initializes class elements
        /// </summary>
        public Drone(Coordinate currentPosition):base(currentPosition)
        {
        }

        /// <summary>
        /// method FlyTo checks to fly or not
        /// </summary>
        public bool FlyTo(Coordinate newCoordinate)
        {
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
            double stopDistance = _speed * _stopPeriod;
            int NumberOfStops = (int)(distance / stopDistance);
            double timeForTrip = distance / _speed + NumberOfStops * _stopTime;
            DateTime timeNow = DateTime.Now;
            return timeNow.AddHours(timeForTrip);
        }

        /// <summary>
        /// method CheckDistance checks for maximum distance (1000)
        /// </summary>
        void CheckDistance(float distance)
        {
            if (distance > 1000)
            {
                throw new Exception("Distance is more than 1500 km");
            }

        }
    }
}
