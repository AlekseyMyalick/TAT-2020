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

        /// <summary>
        /// method GeneratesRandomSpeed generates a random number from 0 to 20
        /// </summary>
        public static int GeneratesRandomSpeed()
        {
            int number = random.Next(0, 20);
            return number;
        }
    }
}
