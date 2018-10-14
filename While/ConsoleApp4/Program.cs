using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Balapan akan dimulai dalam...");
            int hitung = 10;
            while (hitung > 0)
            {
                Console.WriteLine(hitung + "...");
                hitung--;
            }
            Console.WriteLine("MULAI!!!");
            Console.ReadKey();
        }
    }
}
