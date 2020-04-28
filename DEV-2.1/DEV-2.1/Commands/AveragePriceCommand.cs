using System;

namespace DEV_2._1
{
    class AveragePriceCommand : ICommand
    {
        CarData _carData;

        public AveragePriceCommand(CarData carData)
        {
            _carData = carData;
        }

        public void Execute()
        {
            Console.WriteLine($"average price is: {_carData.AveragePrice()}");
        }
    }
}
