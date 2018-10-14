using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int panjang, lebar;
            float luas;
            Console.WriteLine("Menghitung luas persegi");
            Console.Write("Masukan nilai panjang : ");
            panjang = int.Parse(Console.ReadLine());
            Console.Write("Masukan nilai lebar : ");
            lebar = int.Parse(Console.ReadLine());
            luas = panjang * lebar;
            Console.Write("Luas persegi adalah :" + luas);
            Console.Read();
           

        }
    }
}
