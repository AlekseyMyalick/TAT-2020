using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace DEV_2._1
{
    class CarData
    {
        XDocument _xCarData;
        //public static CarData _instance;
        //public const string PATH = @"C://Users\user\source\TAT-2020\DEV-2.1\DEV-2.1\bin\Debug\cars.xml";
        public const string PATH = "cars.xml";

        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Car>));

        /// <summary>
        /// Constructor of the class
        /// </summary>
        private CarData()
        {
            _xCarData = new XDocument();

            _xCarData = XDocument.Load(PATH);
        }

        //public static CarData GetInstance()
        //{
        //    if (_instance == null)
        //    {
        //        _instance = new CarData();

        //    }
        //    _xCarData = XDocument.Load(PATH);
        //    return _instance;
        //}

        public static CarData Current { get; } = new CarData();

        /// <summary>
        /// methode CountTypes counts how many different types of cars
        /// </summary>
        /// <returns></returns>
        public int CountTypes()
        {
            return _xCarData.Root.Elements().Select(element => element.Attribute("make").Value)
                .Distinct().Count();

        }

        /// <summary>
        /// methode CountAll counts how many all types of cars 
        /// </summary>
        /// <returns></returns>
        public int CountAll()
        {
            return _xCarData.Root.Elements().Select(element => (int)element
            .Element("quantity")).Sum();
        }

        /// <summary>
        /// methode AveragePrice calculate average car price for all cars
        /// </summary>
        /// <returns></returns>
        public double AveragePrice()
        {
            return _xCarData.Root.Elements().Select(element => (int)element
            .Element("cost")).Average();
        }

        /// <summary>
        /// methode AveragePriceType calculate average car price by brand
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// methode AddCar adds car to CarData
        /// </summary>
        /// <param name="car"></param>
        public void AddCar(Car car)
        {
            //_xCarData.Root.Add(new XElement("Autos",
            //    new XAttribute("make", car.Make),
            //    new XElement("model", car.Model),
            //    new XElement("quantity", car.Quantity),
            //    new XElement("cost", car.CostOne)));
            //_xCarData.Save(PATH);

            //var openFile = new FileStream(PATH, FileMode.OpenOrCreate);
            //var carList = (List<Car>)xmlSerializer.Deserialize(openFile);
            //openFile.Close();
            //var writeFile = new FileStream(PATH, FileMode.Create);
            //carList.Add(car);
            //xmlSerializer.Serialize(writeFile, carList);
            //writeFile.Close();

            XmlSerializer serializer = new XmlSerializer(typeof(List<Car>));
            List<Car> carList = new List<Car>();

            using (FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate))
            {
                List<Car> newCarList = (List<Car>)xmlSerializer.Deserialize(fs);

            }

            using (FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate))
            {
                carList.Add(car);
                serializer.Serialize(fs, carList);
            }




            

        }

        /// <summary>
        /// method Exit ends the program
        /// </summary>
        public void Exit()
        {
            Environment.Exit(0);
        }
    }
}
