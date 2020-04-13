using System;
using System.Collections.Generic;

namespace DEV_2._1
{
    class Invoker
    {
        private ICommand _command;
        private CarData _carData;
        
        public Invoker(CarData carData)
        {
            _carData = carData;
        }

        public void EnterCars()
        {
            while (true)
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
                    
                    Console.WriteLine("Add more cars? (no / yes): ");
                    if (Console.ReadLine().ToLower() == "no")
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.Clear();
        }

        public void ChooseCommand()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Select command: \n" +
                        "- Count types (1) \n" +
                        "- Count all (2) \n" +
                        "- Average price (3) \n" +
                        "- Average price type (4) \n" +
                        "- Exit (5)");
                    string command = Console.ReadLine().ToLower();

                    switch (command)
                    {
                        case "count types":
                        case "1":
                            {
                                SetCommand(new CountTypesCommand(_carData));
                                Run();
                                break;
                            }
                        case "count all":
                        case "2":
                            {
                                SetCommand(new CountAllCommand(_carData));
                                Run();
                                break;
                            }
                        case "average price":
                        case "3":
                            {
                                SetCommand(new AveragePriceCommand(_carData));
                                Run();
                                break;
                            }
                        case "average price type":
                        case "4":
                            {
                                SetCommand(new AveragePriceTypeCommand(_carData));
                                Run();
                                break;
                            }
                        case "exit":
                        case "5":
                            {
                                SetCommand(new ExitCommand());
                                Run();
                                break;
                            }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void SetCommand(ICommand newCommand)
        {
            _command = newCommand;
        }

        public void Run()
        {
            _command?.Execute();
        }
    }
}
