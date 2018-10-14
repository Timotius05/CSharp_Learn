using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Segitiga : BangunDatar
    {
        public double alas = 3;
        public double tinggi = 6;
        public double miring = 4;
        public override double luas()
        {
            Console.WriteLine("Luas Segitiga : {0} ", 0.5 * alas * tinggi);
            return alas;
        }
        public override double keliling()
        {
            Console.WriteLine("Keliiling Segitiga : {0} ", 2 * miring + alas);
            return alas;
        }
    }
}
