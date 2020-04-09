using System;

namespace DEV_2._1
{
    class AveragePriceTypeCommand : ICommand
    {
        public void Execute()
        {
            CarData.GetInstance().AveragePriceType();
        }
    }
}
