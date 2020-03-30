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

        public Airplane(Coordinate currentPosition) : base(currentPosition)
        {
        }

        public bool FlyTo(Coordinate newCoordinate)
        {
            return true;
        }

        public DateTime GetFlyTime(Coordinate newCoordinate)
        {
            float distance = CurrentPosition.DistanceBetweenPoints(newCoordinate);
            DateTime time = DateTime.Now;
            return time.AddHours((double)TimeCounting(distance));
        }

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
