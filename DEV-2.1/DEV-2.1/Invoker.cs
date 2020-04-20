using System;
using System.Collections.Generic;
using DEV_2._1.Commands;


namespace DEV_2._1
{
    class Invoker
    {
        private ICommand _command;
        private CarData _carData;

        /// <summary>
        /// Constructor of the class
        /// </summary>
        /// <param name="carDealership">Reciever</param>
        public Invoker(CarData carData)
        {
            _carData = carData;
        }

        /// <summary>
        /// Method that allows user to enter commands
        /// </summary>
        public void ChooseCommand()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Select command: \n" +
                        "- Add car (1) \n" +
                        "- Count types (2) \n" +
                        "- Count all (3) \n" +
                        "- Average price (4) \n" +
                        "- Average price type (5) \n" +
                        "- Exit (6)");
                    string command = Console.ReadLine().ToLower();

                    switch (command)
                    {
                        case "add car":
                        case "1":    
                            {
                                SetCommand(new AddCarsCommand(_carData));
                                Run();
                                Console.Clear();
                                break;
                            }
                        case "count types":
                        case "2":
                            {
                                SetCommand(new CountTypesCommand(_carData));
                                Run();
                                break;
                            }
                        case "count all":
                        case "3":
                            {
                                SetCommand(new CountAllCommand(_carData));
                                Run();
                                break;
                            }
                        case "average price":
                        case "4":
                            {
                                SetCommand(new AveragePriceCommand(_carData));
                                Run();
                                break;
                            }
                        case "average price type":
                        case "5":
                            {
                                SetCommand(new AveragePriceTypeCommand(_carData));
                                Run();
                                break;
                            }
                        case "exit":
                        case "6":
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

        /// <summary>
        /// Method that sets new command
        /// </summary>
        /// <param name="newCommand"></param>
        public void SetCommand(ICommand newCommand)
        {
            _command = newCommand;
        }

        /// <summary>
        /// Method that executes the command
        /// </summary>
        public void Run()
        {
            _command?.Execute();
        }
    }
}
