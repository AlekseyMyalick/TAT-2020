using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1._4
{
    interface IFlyable
    {
        bool FlyTo(Coordinate newCoordinate);
        DateTime GetFlyTime(Coordinate newCoordinate);
    }
}
