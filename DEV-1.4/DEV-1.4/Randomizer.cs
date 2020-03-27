using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1._4
{
    public class Randomizer
    {
        public static Random random = new Random((int)DateTime.Now.Ticks);

        public static int GeneratesRandomNumber()
        {
            int number = random.Next(1, 20);
            return number;
        }
    }
}
