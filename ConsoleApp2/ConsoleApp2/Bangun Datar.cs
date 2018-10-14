using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Bangun_Datar
    {
            public double persegi()
            {
                Console.Clear();
                Console.WriteLine("LUAS DAN KELILING PERSEGI");
                Console.WriteLine();
                Console.Write("Input Sisi        : ");
                double s = Convert.ToInt64(Console.ReadLine());

                Console.WriteLine("=======================");
                Console.WriteLine("Luas Persegi      : {0}", s * s);
                Console.WriteLine("Keliling Persegi  : {0}", 2 * s * s);
                Console.ReadLine();

                return (s);
            }
            public double segitiga()
            {
                Console.Clear();
                Console.WriteLine("LUAS DAN KELILING SEGITIGA");
                Console.WriteLine();
                Console.Write("Input Alas        : ");
                double x = Convert.ToInt64(Console.ReadLine());

                Console.Write("Input Tinggi      : ");
                double y = Convert.ToInt64(Console.ReadLine());

                Console.Write("Input Sisi miring : ");
                double m = Convert.ToInt64(Console.ReadLine());

                double alas = x * y / 2;
                Console.WriteLine("=======================");
                Console.WriteLine("Luas Segitiga     : " + alas);
                Console.WriteLine("Keliling Segitiga : {0}", m + y + x);
                Console.ReadLine();
                return alas;
            }
            public double persegip()
            {
                Console.Clear();
                Console.WriteLine("LUAS DAN KELILING PERSEGI PANJANG");
                Console.WriteLine();
                Console.Write("Input Sisi Pendek         : ");
                double sk = Convert.ToInt64(Console.ReadLine());

                Console.Write("Input Sisi Panjang        : ");
                double sj = Convert.ToInt64(Console.ReadLine());

                Console.WriteLine("================================");
                Console.WriteLine("Luas Persegi Panjang      : {0}", sk * sj);
                Console.WriteLine("Keliling Persegi Panjang  : {0}", 2 * (sk + sj));
                Console.ReadLine();

                return sk;



            }

        }
    }


