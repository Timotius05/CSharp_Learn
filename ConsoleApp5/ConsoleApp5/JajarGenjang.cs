using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class JajarGenjang : BangunDatar
    {
        public double alas = 3;
        public double tinggi = 6;
        public double miring = 4;
        public override double luas()
        {
            Console.WriteLine("Luas Jajar Genjang : {0} ", alas * tinggi);
            return alas;
        }
        public override double keliling()
        {
            Console.WriteLine("Keliiling Jajar Genjang : {0} ", 2 * alas * miring);
            return alas; 
        } 
    }
}
