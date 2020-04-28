using System;

namespace DEV_2._1
{
    class CountTypesCommand : ICommand
    {
        CarData _carData;

        public CountTypesCommand(CarData carData)
        {
            _carData = carData;
        }

        public void Execute()
        {
            Console.WriteLine($"total number of cars: {_carData.CountTypes()}");
        }
    }
}
