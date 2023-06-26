using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer epson = new Epson();
            Printer canon = new Canon();
            Printer laserjet = new Laserjet();

            epson.Merk = "Epson\n";
            epson.Show = "Epson display dimension : 10*11\n";

            canon.Merk = "Canon\n";
            canon.Show = "Canon display dimension : 9.5*12\n";

            laserjet.Merk = "Laserjet\n";
            laserjet.Show = "LaserJet display dimension : 11*12\n";
            Console.WriteLine("==================================================");
            Console.WriteLine("Silahkan pilih jenis Printer berikut ini : ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet\n");

            Console.Write("Pilih jenis Printer yang ingin digunakan [1...3] :");
            int pilih = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("==================================================");
            //pengkondisian
            if (pilih == 1)
                epson.Print();
            else if (pilih == 2)
                canon.Print();
            else if (pilih == 3)
                laserjet.Print();
            else
                Console.WriteLine("Jenis Printer yang anda pilih {0} tidak ada", pilih);

            Console.ReadLine();
            return;
        }
    }
}
