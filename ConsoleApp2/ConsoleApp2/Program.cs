﻿using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bangun_Datar bd = new Bangun_Datar();
            Console.WriteLine("MAIN MENU");
            Console.WriteLine("1. Segitiga");
            Console.WriteLine("2. Perseg");
            Console.WriteLine("3. Persegi Panjang");
            Double a = Convert.ToInt64(Console.ReadLine());
            if (a == 1)
            {
                bd.segitiga();
            }
            if (a == 2)
            {
                bd.persegi();
            }
            if (a == 3)
            {
                bd.persegip();
            }
        }
    }
}
