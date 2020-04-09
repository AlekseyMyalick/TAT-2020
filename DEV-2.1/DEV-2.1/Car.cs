using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_2._1
{
    class Car
    {
        private string _make;
        private string _model;
        private int _quantity;
        private int _costOne;


        public Car(string make, string model, int quantity, int costOne)
        {
            Make = make;
            Model = model;
            Quantity = quantity;
            CostOne = costOne;
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

        public int Quantity
        {
            get
            {
                return _quantity;
            }

            set
            {
                CheckQuantity(value);
            }
        }

        public int CostOne
        {
            get
            {
                return _costOne;
            }

            set
            {
                CheclCostOne(value);
            }
        }

        public void CheckQuantity(int value)
        {
            try
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Incorrect quantity!");
                }
                _costOne = value;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Enter coorect car quantity: ");
                Int32.TryParse(Console.ReadLine(), out int quantity);
                Quantity = quantity;
            }
        }

        public void CheclCostOne(int value)
        {
            try
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Incorrect price!");
                }
                _costOne = value;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Enter coorect car price: ");
                Int32.TryParse(Console.ReadLine(), out int costOne);
                CostOne = costOne;
            }
        }
    }
}
