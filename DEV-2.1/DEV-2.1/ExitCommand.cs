using System;

namespace DEV_2._1
{
    class ExitCommand : ICommand
    {
        CarData _carData;

        public ExitCommand(CarData carData)
        {
            _carData = carData;
        }

        public void Execute()
        {
            _carData.Exit();
        }

        public void Undo() { }
    }
}
