using System;

namespace DEV_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarData carData = CarData.GetInstance();
                Invoker invoker = new Invoker();
                invoker.SetCommand(new CountTypesCommand(carData));
                invoker.SetCommand(new CountAllCommand(carData));
                invoker.SetCommand(new AveragePriceCommand(carData));
                invoker.SetCommand(new AveragePriceTypeCommand(carData));
                invoker.Run();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
