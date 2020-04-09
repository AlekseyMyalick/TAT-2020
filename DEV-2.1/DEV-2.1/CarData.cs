using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace DEV_2._1
{
    class CarData
    {
        static XDocument _xCarData;
        public static CarData _instance;
        public const string PATH = @"C://Users\user\source\TAT-2020\DEV-2.1\DEV-2.1\bin\Debug\cars.xml";

        private CarData()
        {
            _xCarData = XDocument.Load(PATH);
        }

        public static CarData GetInstance()
        {
            if (_instance == null)
            {
                _instance = new CarData();

            }
            return _instance;
        }

        public int CountTypes()
        {
            var totalTypesAutos = 1;
            XElement previuosElement = _xCarData.Root.Element("Autos");
            foreach (XElement element in _xCarData.Root.Elements())
            {
                if (previuosElement.Attribute("name").Value != element.Attribute("name").Value)
                {
                    totalTypesAutos++;
                }
                previuosElement = element;
            }
            Console.WriteLine($"total number of cars:{totalTypesAutos}");
            return totalTypesAutos;
        }

        public int CountAll()
        {
            var totalCountAutos = 0;
            foreach (XElement element in _xCarData.Root.Elements())
            {
                totalCountAutos += (int)element.Element("count");
            }
            Console.WriteLine($"total number of cars:{totalCountAutos}");
            return totalCountAutos;
        }

        public double AveragePrice()
        {
            double averagePrice = 0;
            double totalSum = 0;
            double countAutos = 0;
            foreach (XElement element in _xCarData.Root.Elements())
            {
                totalSum += (double)element.Element("cost");
                countAutos++;
            }
            averagePrice = totalSum / countAutos;
            Console.WriteLine($"average price is: {averagePrice}");
            return averagePrice;
        }

        public double AveragePriceType()
        {
            double totalSum = 0;
            double averageTypePrice = 0;
            double countAutos = 0;
            string inputName = Console.ReadLine();

            foreach (XElement element in _xCarData.Root.Elements())
            {
                if (element.Attribute("name").Value == inputName)
                {
                    totalSum += (double)element.Element("cost");
                    countAutos++;
                }
            }

            averageTypePrice = totalSum / countAutos;
            Console.WriteLine($"average type price is: {averageTypePrice}");
            return averageTypePrice;
        }

        public void Exit()
        {
            Environment.Exit(0);
        }
    }
}
