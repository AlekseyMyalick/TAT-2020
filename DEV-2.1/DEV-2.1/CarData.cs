using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_2._1
{
    public class CarData
    {
        private string _make;
        private string _model;
        private string _quantity;
        private string _costOne;

        public CarData()
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
    }
}
