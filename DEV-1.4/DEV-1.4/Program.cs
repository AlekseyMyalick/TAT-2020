using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinate coordinate1 = new Coordinate(1,1,1);
            Coordinate coordinate2 = new Coordinate(100,100,100);

            Bird siniza = new Bird(coordinate1);
            Console.WriteLine(siniza.FlyTo(coordinate2));
            Console.WriteLine(siniza.GetFlyTime(coordinate2));

            Airplane boing = new Airplane(coordinate1);
            Console.WriteLine(boing.FlyTo(coordinate2));
            Console.WriteLine(boing.GetFlyTime(coordinate2));

            Drone drone = new Drone(coordinate1);
            Console.WriteLine(drone.FlyTo(coordinate2));
            Console.WriteLine(drone.GetFlyTime(coordinate2));
        }
    }
}
