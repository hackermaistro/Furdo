using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace furdo
{
    internal class adatsor
    {
        public int vendegazonosito {  get; set; }
        public int furdoazonosito { get; set; }
        public bool beki { get; set; }
        public int ora { get; set; }
        public int perc { get; set; }
        public int masodperc { get; set; }
        public adatsor(string sor)
        {
            string[] sz = sor.Split(' ');
            vendegazonosito = int.Parse(sz[0]);
            furdoazonosito = int.Parse(sz[1]);
            if (int.Parse(sz[2]) == 0)
            {
                beki = true;
            }
            ora = int.Parse(sz[3]);
            perc=int.Parse(sz[4]);
            masodperc = int.Parse(sz[5]);

        }
    }
}
