using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Printer
    {
        public string Show { get; set; }
        public string Merk { get; set; }
        public abstract void Print();
    }
}
