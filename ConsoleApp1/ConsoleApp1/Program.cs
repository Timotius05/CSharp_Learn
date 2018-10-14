using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            BangunDatar persegi = new BangunDatar();
            BangunDatar segitiga = new BangunDatar();
            BangunDatar persegipanjang = new BangunDatar();

            persegi.luasp();
            persegi.kelilingp();
            segitiga.luass();
            segitiga.kelilings();
            persegipanjang.luaspp();
            persegipanjang.kelilingpp();
            Console.ReadLine();
        }
    }
}
