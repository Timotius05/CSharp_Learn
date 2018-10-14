using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Lingkaran : BangunDatar
    {
        public double jari = 3;
        public override double luas()
        {
            Console.WriteLine("Luas Lingkaran : {0} ", 22/7 * jari * jari);
            return jari;
        }
        public override double keliling()
        {
            Console.WriteLine("Keliiling Lingkaran : {0} ", 2 * 22/7 + jari);
            return jari;
        }
    }
}
