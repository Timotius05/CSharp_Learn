using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Persegi : BangunDatar
    {
        public double sisi = 2;
        public override double luas()
        {
            Console.WriteLine("Luas Persegi : {0} ", sisi * sisi);
            return sisi;
        }
        public override double keliling()
        {
            Console.WriteLine("Keliiling Persegi : {0} ", 4* sisi);
            return sisi;
        }


}
}
