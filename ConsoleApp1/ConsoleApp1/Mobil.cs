using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class BangunDatar
    {
        int sisi = 10;
        int panjang = 8;
        int lebar = 5;
        int tinggi = 7;
        int alas = 10;
        int sisimiring = 5;

        public int luasp()
        {
            Console.Write("Luas persegi adalah : {0},", sisi * sisi);
            return (sisi);
        }
        public int kelilingp()
        {
            Console.WriteLine(" Keliling persegi adalah : {0}", sisi * 4);
            return (sisi);
        }

        public int luass()
        {
            Console.Write("Luas segitiga adalah : {0}", 0.5 * alas * tinggi);
            return ((alas*tinggi)/2);
        }

        public int kelilings()
        {
            Console.WriteLine(" Keliling segitiga adalah : {0}", 2 * sisimiring + alas);
            return ((2*sisimiring)+alas);
        }

        public int luaspp()
        {
            Console.Write("Luas persegi panjang adalah : {0}", panjang * lebar);
            return (panjang * lebar);
        }

        public int kelilingpp()
        {
            Console.Write(" Keliling persegi panjang adalah : {0}", 2 * panjang + lebar);
            return ((panjang+lebar)*2);
        }
    }
}
