using System;

namespace DEV_2._1
{
    class CountAllCommand : ICommand
    {
        CarData _carData;

        public CountAllCommand(CarData carData)
        {
            _carData = carData;
        }

        public void Execute()
        {
            Console.WriteLine($"total number of all cars: {_carData.CountAll()}");
        }
    }
}
