﻿using System;

namespace DEV_1._4
{
    public struct Coordinate
    {
        private float _x;
        private float _y;
        private float _z;

        public Coordinate(float x, float y, float z)
        {
            if (x < 0 || y < 0 || z < 0)
            {
                throw new Exception("Less then zero");
            }
            this._x = x;
            this._y = y;
            this._z = z;
        }

        public float DistanceBetweenPoints(Coordinate coordinate)
        {
            return (float)Math.Sqrt(Math.Pow((coordinate._x - _x), 2)
            + Math.Pow((coordinate._y - _y), 2)
            + Math.Pow((coordinate._z - _z), 2));
        }
    }
}

