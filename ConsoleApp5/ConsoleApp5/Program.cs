using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Persegi persegi1 = new Persegi();
            PersegiPanjang persegiPanjang1 = new PersegiPanjang();
            JajarGenjang JajarGenjang1 = new JajarGenjang();
            Segitiga segitiga1 = new Segitiga();
            Lingkaran lingakran1 = new Lingkaran();
            Trapesium trapesium1 = new Trapesium();
            belahketupat belahketupat1 = new belahketupat();

            persegi1.luas();
            persegi1.keliling();
            persegiPanjang1.luas();
            persegiPanjang1.keliling();
            JajarGenjang1.luas();
            JajarGenjang1.keliling();
            segitiga1.luas();
            segitiga1.keliling();
            lingakran1.luas();
            lingakran1.keliling();
            trapesium1.luas();
            trapesium1.keliling();
            belahketupat1.luas();
            belahketupat1.keliling();

            Console.ReadLine();
        }
    }
}
