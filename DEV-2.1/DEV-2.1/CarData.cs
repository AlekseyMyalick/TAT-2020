using System;

namespace DEV_2._1
{
    class CarData
    {
        public static CarData instance;
        public ExcelTable excelTable { get; set; }

        private CarData()
        {
            excelTable = new ExcelTable(@"C:\Users\user\source\TAT-2020\DEV-2.1\DEV-2.1\bin\Debug\test.xlsx", 1);
        }

        public static void ReadData(Car car)
        {
            Console.Write("Make: ");
            car.Make = Console.ReadLine();
            Console.Write("Model: ");
            car.Model = Console.ReadLine();
            Console.Write("Quantity: ");
            car.Quantity = Console.ReadLine();
            Console.Write("Cost one: ");
            car.CostOne = Console.ReadLine();
        }

        public void WriteData(Car car)
        {           
            int count = excelTable.NumberOfNonEmptyLines();
            excelTable.WriteToCell(count, 1, car.Make);
            excelTable.WriteToCell(count, 2, car.Model);
            excelTable.WriteToCell(count, 3, car.Quantity);
            excelTable.WriteToCell(count, 4, car.CostOne);
            excelTable.Save();
            //excelTable.Close();
        }

        public static CarData GetInstance()
        {
            if (instance == null)
            {
                instance = new CarData();

            }
            return instance;
        }

        public int CountTypes()
        {
           
            excelTable.Close();

            return 1;
        }

        public int CountAll()
        {
            int countLines = excelTable.NumberOfNonEmptyLines();
            int countCars = 0;
            for (int i = 1; i < countLines; i++)
            {
                countCars += Convert.ToInt32(excelTable.ReadCell(i, 3));
            }
            Console.WriteLine(countCars);
            return countCars;
        }

        public double AveragePrice()
        {
            int countLines = excelTable.NumberOfNonEmptyLines();
            double Allprice = 0;
            for (int i = 1; i < countLines; i++)
            {
                Allprice += Convert.ToDouble(excelTable.ReadCell(i, 4));
            }
            Console.WriteLine(Allprice/(countLines-1));
            return Allprice / (countLines - 1);
        }

        public float AveragePriceType()
        {
            return 1;
        }

        public void Exit()
        {

        }
    }
}
