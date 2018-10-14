using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kalkulator;

namespace kalkulator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Menghitung hitung1 = new Menghitung();

            Console.WriteLine(hitung1.add(2, 8));
            Console.WriteLine(hitung1.min(2, 7));
            Console.WriteLine(hitung1.devide(3, 0));
            Console.ReadLine();
        }
    }
}
