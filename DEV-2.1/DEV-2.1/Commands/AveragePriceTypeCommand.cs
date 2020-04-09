using System;

namespace DEV_2._1
{
    class AveragePriceTypeCommand : ICommand
    {
        CarData _carData;

        public AveragePriceTypeCommand(CarData carData)
        {
            _carData = carData;
        }

        public void Execute()
        {
            _carData.AveragePriceType();
        }
    }
}
