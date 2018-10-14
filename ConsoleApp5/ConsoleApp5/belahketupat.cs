using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class belahketupat : BangunDatar
    {
        public double alas = 6;
        public double tinggi = 6;
        public override double luas()
        {
            Console.WriteLine("Luas Belah Ketupat : {0} ", alas * tinggi);
            return alas;
        }
        public override double keliling()
        {
            Console.WriteLine("Keliiling Belah Ketupat : {0} ", 2 * (alas + tinggi));
            return alas;
        }
    }
}
