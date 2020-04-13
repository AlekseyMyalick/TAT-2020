using System;

namespace DEV_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var carData = CarData.Current;
            var invoker = new Invoker(carData);
            invoker.EnterCars();
            invoker.ChooseCommand();
        }
    }
}
