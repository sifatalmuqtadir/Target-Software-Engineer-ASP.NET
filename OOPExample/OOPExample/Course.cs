using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample
{
    public class Calculator
    {
        public int Calculate(int mid, int final) => mid + final;
    }

    public class Course
    {
        public int GetResult()
        {
            // Local variables - remove 'public'
            int mid = 20;
            int final = 30;

            Calculator calculator = new Calculator();
            int result = calculator.Calculate(mid, final);

            return result;
        }
    }
}
