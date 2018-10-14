using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Masukkan Angka 1 = ");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Masukkan Angka 2 = ");
                double y = double.Parse(Console.ReadLine());
                double z = x - y;
                Console.WriteLine(z);
            }
            catch(FormatException salah)
            {
                Console.WriteLine("Msaukkan anda salah");
                Console.WriteLine(salah.Message);
            }
            Console.ReadLine();

        }
    }
}
