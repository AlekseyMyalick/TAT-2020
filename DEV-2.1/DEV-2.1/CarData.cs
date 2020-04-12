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
            Console.WriteLine($"total number of cars:{_xCarData.Root.Elements().Select(element => element.Attribute("name").Value).Distinct().Count()}");
            return _xCarData.Root.Elements().Select(element => element.Attribute("name").Value)
                .Distinct().Count();

        }

        public int CountAll()
        {
            Console.WriteLine($"total number of cars:{_xCarData.Root.Elements().Select(element => (int)element.Element("count")).Sum()}");
            return _xCarData.Root.Elements().Select(element => (int)element.Element("count")).Sum();
        }

        public double AveragePrice()
        {
            Console.WriteLine($"average price is: {_xCarData.Root.Elements().Select(element => (int)element.Element("cost")).Average()}");
            return _xCarData.Root.Elements().Select(element => (int)element.Element("cost")).Average();

        }

        public double AveragePriceType()
        {
            Console.Write("Enter brand name: ");
            string inputName = Console.ReadLine();

            if (_xCarData.Root.Elements().Any(elememt =>
            elememt.Attribute("name").Value.ToLower() == inputName.ToLower()))
            {
                return _xCarData.Root.Elements().Where(elememt =>
                   elememt.Attribute("name").Value.ToLower() == inputName.ToLower())
                    .Select(element => (int)element.Element("cost")).Average();

            }

            throw new ArgumentException("There's no cars with such brand");
        }

        public void Exit()
        {
            Environment.Exit(0);
        }
    }
}
