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

        /// <summary>
        /// Constructor of the class
        /// </summary>
        public Car(string make, string model, int quantity, int costOne)
        {
            Make = make;
            Model = model;
            Quantity = quantity;
            CostOne = costOne;
        }

        /// <summary>
        /// property Make accepts and returns a value
        /// </summary>
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

        /// <summary>
        /// property Model accepts and returns a value
        /// </summary>
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

        /// <summary>
        /// property Quantity accepts and returns a value
        /// </summary>
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

        /// <summary>
        /// property CostOne accepts and returns a value
        /// </summary>
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

        /// <summary>
        /// methode CheckQuantity checks quantity to zero
        /// </summary>
        /// <param name="value"></param>
        public void CheckQuantity(int value)
        {
            try
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Incorrect quantity!");
                }
                _quantity = value;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Enter coorect car quantity: ");
                Int32.TryParse(Console.ReadLine(), out int quantity);
                Quantity = quantity;
            }
        }

        /// <summary>
        /// methode CheckCostOne checks cosOne to zero
        /// </summary>
        /// <param name="value"></param>
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
