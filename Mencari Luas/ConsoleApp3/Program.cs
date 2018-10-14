using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double alas, tinggi, luas, sisi;
            int pilihan = 0;
            Console.WriteLine("Menu Perhitungan Luas Bangun Datar");
            Console.WriteLine("1.Segitiga");
            Console.WriteLine("2.Persegi");
            Console.WriteLine();

            Console.WriteLine("Masukkan Pilihan Anda : ");

            pilihan = int.Parse(Console.ReadLine());
            if(pilihan==1)
            {
                Console.Write("Masukan Nilai Alas : ");
                alas = double.Parse(Console.ReadLine());
                Console.Write("Masukan Nilai Tinggi : ");
                tinggi = double.Parse(Console.ReadLine());
                luas = alas * tinggi / 2;
                Console.Write("Luas Segitiga Adalah : ");
                Console.WriteLine(luas);
            }
            else if(pilihan==2)
            {
                Console.Write("Masukkan Nilai Sisi : ");
                sisi = double.Parse(Console.ReadLine());
                luas = sisi * sisi;
                Console.Write("Hasil Luas Persegi :");
                Console.WriteLine(luas);
            }
            Console.Write("Press any key to continue...");
            Console.ReadKey(true);

        }
        
    }
}
