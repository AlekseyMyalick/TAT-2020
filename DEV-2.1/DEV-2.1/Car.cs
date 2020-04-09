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
        private string _quantity;
        private string _costOne;


        public Car()
        {
            
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
