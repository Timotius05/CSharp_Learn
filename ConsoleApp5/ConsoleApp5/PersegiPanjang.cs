using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class PersegiPanjang : BangunDatar
    {
        public double panjang = 4;
        public double lebar = 5;
        public override double luas()
        {
            Console.WriteLine("Luas PersegiPanjang : {0} ", panjang * lebar );
            return panjang;
        }
        public override double keliling()
        {
            Console.WriteLine("Keliiling PersegiPanjang : {0} ", 2 * (panjang + lebar));
            return panjang;
        }
    }
}
