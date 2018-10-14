using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Trapesium : BangunDatar
    {
        public double alas = 6;
        public double tinggi = 6;
        public double sisiatas = 4;
        public double sisimiring = 5;
        public override double luas()
        {
            Console.WriteLine("Luas Trapesium : {0} ", 0.5 * (alas+sisiatas) * tinggi);
            return alas;
        }
        public override double keliling()
        {
            Console.WriteLine("Keliiling Trapesium : {0} ", alas + sisiatas + sisimiring + tinggi);
            return alas;
        }
    }
}
