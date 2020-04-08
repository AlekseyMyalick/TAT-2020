using System;

namespace DEV_2._1
{
    class CarData
    {
        private string _make;
        private string _model;
        private string _quantity;
        private string _costOne;


        public CarData()
        {
            ReadData();
            WriteData();
        }

        public string Make
        {
            get
            {
                return _make;
            }

            set
            {
                _make = value;
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }

            set
            {
                _model = value;
            }
        }

        public string Quantity
        {
            get
            {
                return _quantity;
            }

            set
            {
                _quantity = value;
            }
        }

        public string CostOne
        {
            get
            {
                return _costOne;
            }

            set
            {
                _costOne = value;
            }
        }

        public void ReadData()
        {
            Console.Write("Make: ");
            Make = Console.ReadLine();
            Console.Write("Model: ");
            Model = Console.ReadLine();
            Console.Write("Quantity: ");
            Quantity = Console.ReadLine();
            Console.Write("Cost one: ");
            CostOne = Console.ReadLine();
        }

        public void WriteData()
        {
            excelTable = ExcelTable.GetInstance(@"C:\Users\user\source\TAT-2020\DEV-2.1\DEV-2.1\bin\Debug\test.xlsx", 1);
            //ExcelTable excelTable = new ExcelTable(@"C:\Users\user\source\TAT-2020\DEV-2.1\DEV-2.1\bin\Debug\test.xlsx", 1);
            int count = excelTable.NumberOfNonEmptyLines();
            excelTable.WriteToCell(count, 1, Make);
            excelTable.WriteToCell(count, 2, Model);
            excelTable.WriteToCell(count, 3, Quantity);
            excelTable.WriteToCell(count, 4, CostOne);
            excelTable.Save();
            //excelTable.Close();
        }

        public ExcelTable excelTable { get; set; }

        public int CountTypes()
        {
            return 1;
        }

        public int CountAll()
        {
            excelTable = ExcelTable.GetInstance(@"C:\Users\user\source\TAT-2020\DEV-2.1\DEV-2.1\bin\Debug\test.xlsx", 1);
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
            excelTable = ExcelTable.GetInstance(@"C:\Users\user\source\TAT-2020\DEV-2.1\DEV-2.1\bin\Debug\test.xlsx", 1);
            int countLines = excelTable.NumberOfNonEmptyLines();
            Double Allprice = 0;
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
