﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1._4
{
    class Bird:IFlyable
    {
        Coordinate _currentPosition;

        public Bird(Coordinate currentPosition)
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

        public Coordinate FlyTo()
        {

        } 

        public Coordinate GetFlyTime()
        {

        }
    }
}
