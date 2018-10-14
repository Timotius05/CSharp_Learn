using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int alas, tinggi;
            float luas;
            Console.WriteLine("=======Menghitung Luas Segitiga=======");
            Console.Write("Masukan Nilai Alas : ");
            alas = int.Parse(Console.ReadLine());
            Console.Write("Masukan Nilai Tinggi : ");
            tinggi = int.Parse(Console.ReadLine());
            luas = alas * tinggi / 2;
            Console.Write("Luas Segitiga Adalah : " + luas);
            Console.Read();
            

        }
    }
}
