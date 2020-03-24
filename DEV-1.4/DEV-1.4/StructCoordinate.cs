using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

