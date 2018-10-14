using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class segitiga_enkapsulasi
    {
        private double alas;
        private double tinggi;
        private double sisim;

        public double getalas()
        {
            return alas;
        }

        public double setalas(double nalas)
        {
            alas += nalas;
            return nalas;
        }

        public double gettinggi()
        {
            return tinggi;
        }

        public double settinggi(double ntinggi)
        {
            alas += ntinggi;
            return ntinggi;
        }

        public double getsisim()
        {
            return sisim;
        }

        public double setsisim(double nsisim)
        {
            alas += nsisim;
            return nsisim;
        }
    }
}
