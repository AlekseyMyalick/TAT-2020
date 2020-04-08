using System;

namespace DEV_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();
            CarData carData = new CarData();
            //CountAllCommand countAllCommand = new CountAllCommand(carData);
            AveragePriceCommand averagePriceCommand = new AveragePriceCommand(carData);
            invoker.SetCommand(averagePriceCommand);
            invoker.Run();
        }
    }
}
