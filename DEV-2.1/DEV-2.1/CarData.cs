using System;
using System.Linq;
using System.Xml.Linq;

namespace DEV_2._1
{
    class CarData
    {
        static XDocument _xCarData;
        public static CarData _instance;
        public const string PATH = @"C://Users\user\source\TAT-2020\DEV-2.1\DEV-2.1\bin\Debug\cars.xml";

        /// <summary>
        /// Constructor of the class
        /// </summary>
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
            _xCarData = XDocument.Load(PATH);
            return _instance;
        }

        public static CarData Current { get; } = new CarData();

        public int CountTypes()
        {
            return _xCarData.Root.Elements().Select(element => element.Attribute("make").Value)
                .Distinct().Count();

        }

        public int CountAll()
        {
            return _xCarData.Root.Elements().Select(element => (int)element
            .Element("quantity")).Sum();
        }

        public double AveragePrice()
        {
            return _xCarData.Root.Elements().Select(element => (int)element
            .Element("cost")).Average();
        }

        public double AveragePriceType()
        {
            Console.Write("Enter brand name: ");
            string inputName = Console.ReadLine();

            if (_xCarData.Root.Elements().Any(elememt =>
            elememt.Attribute("make").Value.ToLower() == inputName.ToLower()))
            {
                return _xCarData.Root.Elements().Where(elememt =>
                   elememt.Attribute("make").Value.ToLower() == inputName.ToLower())
                    .Select(element => (int)element.Element("cost")).Average();
            }

            throw new ArgumentException("There's no cars with such brand");
        }

        public void AddCar(Car car)
        {
            _xCarData.Root.Add(new XElement("Autos",
                new XAttribute("make", car.Make),
                new XElement("model", car.Model),
                new XElement("quantity", car.Quantity),
                new XElement("cost", car.CostOne)));
            _xCarData.Save(PATH);
        }

        public void Exit()
        {
            Environment.Exit(0);
        }
    }
}
