using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;

            hitung kal = new hitung();

            Console.Write("Masukkan Nilai Bilangan Pertama   :");
            x = double.Parse(Console.ReadLine());
            Console.Write("Masukkan Nilai Bilangan Kedua     :");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine("....................................");
            Console.WriteLine(kal.add(x, y));
            Console.WriteLine(kal.min(x, y));
            Console.WriteLine(kal.cross(x, y));
            Console.WriteLine(kal.devide(x, y));

            Console.ReadLine();
         

        }
    }
}
