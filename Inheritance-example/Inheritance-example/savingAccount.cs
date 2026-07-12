using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_example
{
    public class savingAccount : bankAccount
    {
        public double serviceCharge { get; set; }
        public double interestAmount { get; set; }
    }
}
