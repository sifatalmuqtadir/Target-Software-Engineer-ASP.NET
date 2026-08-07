using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_type_example_in_C_
{
    public class Box<T>
    {
        public T Data { get; set; }

        // Normal method using class generic type T
        public void ShowData()
        {
            Console.WriteLine("Box Data: " + Data);
        }

        // Generic method using another type U
        public void Show<U>(U value)
        {
            Console.WriteLine("Other Data: " + value);
        }
    }
}
