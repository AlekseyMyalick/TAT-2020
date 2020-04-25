using System;

namespace DegreesFeetCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length < 2)
                {
                    throw new ArgumentException();
                }

                Creater creater = new Creater();

                if (args[1] == "CF" || args[1] == "FC")
                {
                    Console.WriteLine(creater.CreateCelsiusFahrenheit()
                        .Convert(Convert.ToDouble(args[0]), args[1]));
                }

                else if (args[1] == "MF" || args[1] == "FM")
                {
                    Console.WriteLine(creater.CreateFeetMeters()
                        .Convert(Convert.ToDouble(args[0]), args[1]));
                }

            }
            catch (ArgumentException)
            {
                Console.WriteLine("Incorrect arguments");
            }
        }
    }
}
