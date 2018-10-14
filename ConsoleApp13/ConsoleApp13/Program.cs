using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            segitiga_enkapsulasi segitiga1 = new segitiga_enkapsulasi();

            segitiga1.getalas();
            segitiga1.gettinggi();
            segitiga1.getsisim();

            Console.Write("Masukkan Alas : ");
            double a = Convert.ToInt64(Console.ReadLine());
            Console.Write("Masukkan Tinggi : ");
            double t = Convert.ToInt64(Console.ReadLine());
            Console.Write("Masukkan Sisi Miring : ");
            double s = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Luas Segitiga :" + a * t / 2);
            Console.Write("Keliling Segitiga :" + a + t + s + s);
            Console.ReadLine();

        }
    }
}
