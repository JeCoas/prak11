using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Canon : Printer
    {
        public override void Print()
        {
            Console.WriteLine("Merk Printer : {0}", Merk);
            Console.WriteLine("Menampilkan : {0}", Show);

            Console.WriteLine("Canon printer printing....");
        }
    }
}
