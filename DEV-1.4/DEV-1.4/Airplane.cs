using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1._4
{
    class Airplane:Flying, IFlyable
    {
        int _startingSpeed = 200;
        int _maxSpeed = 1500;

        /// <summary>
        /// constructor initializes class elements
        /// </summary>
        public Airplane(Coordinate currentPosition) : base(currentPosition)
        {
        }

        /// <summary>
        /// method FlyTo checks to fly or not
        /// </summary>
        public bool FlyTo(Coordinate newCoordinate)
        {
            return true;
        }

        /// <summary>
        /// method GetFlyTime returns flight time
        /// </summary>
        public DateTime GetFlyTime(Coordinate newCoordinate)
        {
            float distance = CurrentPosition.DistanceBetweenPoints(newCoordinate);
            DateTime time = DateTime.Now;
            return time.AddHours((double)TimeCounting(distance));
        }

        /// <summary>
        /// method TimeCounting considers time considering features
        /// </summary>
        public float TimeCounting(float distance)
        {
            int speed = _startingSpeed;
            float flyTime = 0;
            float way = 0;
            int speedIncrease;

            while (way < distance)
            {
                way += speed;
                if (speed < _maxSpeed)
                {
                    speedIncrease = (int)way / 10;
                    speed = _startingSpeed + speedIncrease;
                }
                else
                {
                    speed = _maxSpeed;
                }
                flyTime++;
            }

            if (way > distance)
            {
                flyTime -= (way - distance) / speed;
            }

            return flyTime;
        }
    }
}
