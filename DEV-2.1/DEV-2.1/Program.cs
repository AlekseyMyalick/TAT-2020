using System;

namespace DEV_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();           
            //CountAllCommand countAllCommand = new CountAllCommand(carData);
            //AveragePriceCommand averagePriceCommand = new AveragePriceCommand(carData);
            CountTypesCommand countTypesCommand = new CountTypesCommand();
            invoker.SetCommand(countTypesCommand);
            invoker.Run();
        }
    }
}
