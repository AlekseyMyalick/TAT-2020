using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_2._1.Commands
{
    class AddCarsCommand : ICommand
    {
        private CarData _carData;

        public AddCarsCommand(CarData carData)
        {
            _carData = carData;
        }

        public void Execute()
        {
            try
            {
                Console.Write("Enter car make: ");
                string make = Console.ReadLine();

                Console.Write("Enter car model: ");
                string model = Console.ReadLine();

                Console.Write("Enter number of cars: ");
                Int32.TryParse(Console.ReadLine(), out int quantity);

                Console.Write("Enter car price: ");
                Int32.TryParse(Console.ReadLine(), out int costOne);

                _carData.AddCar(new Car(make, model, quantity, costOne));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

