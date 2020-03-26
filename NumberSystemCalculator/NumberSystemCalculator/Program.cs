using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1_2
{
    class Program
    {
        public static int Number { get; set; }
        public static int NumberSystem { get; set; }

        static void Main(string[] args)
        {
                Number = Convert.ToInt32(args[0]);
                NumberSystem = Convert.ToInt32(args[1]);
                var numbersConverter = new NumberSystem(Number, NumberSystem);
                var convertingResult = numbersConverter.TransferToNewSystem();
                Console.WriteLine($"Result of converting = {convertingResult}"); 
        }
    }
}
