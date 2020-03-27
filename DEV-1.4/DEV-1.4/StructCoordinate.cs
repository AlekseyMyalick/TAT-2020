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

        public float DistanceBetweenPoints(Coordinate coordinate)
        {
            if (coordinate is Coordinate)
            {
                float distance = (float)Math.Sqrt(Math.Pow((_x - coordinate._x), 2) 
                    + Math.Pow((_y - coordinate._y), 2) 
                    + Math.Pow((_z - coordinate._z), 2));
                return distance;
            }
            else
            {
                return 0;
            }
        }
    }
}

