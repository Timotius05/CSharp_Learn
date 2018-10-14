using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int hitung = 10;
            do
            {
                Console.WriteLine(hitung +"--");
                hitung--;
            }
            while (hitung > 0);
            Console.WriteLine("mulai");
            Console.ReadKey();
        }
    }
}
