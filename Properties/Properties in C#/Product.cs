using System;
using System.Collections.Generic;
using System.Text;

namespace Properties_in_C_
{
    class Product
    {
        public string name;
        private int price;

        public int Price
        {
            set
            {
                if (value > 100)
                {
                    price = value;
                }
                else
                {
                    Console.WriteLine("Price must be greater than 100 tk.");
                }
            }
            get {  return price; }
        }
    }
}
