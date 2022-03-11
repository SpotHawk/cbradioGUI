using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbradioGUI
{
    class CBAdas
    {
        public int AdasIdejeOra { get; set; }
        public int AdasIdejePerc { get; set; }
        public int AdasSzam { get; set; }
        public string SoforNev { get; set; }



        public CBAdas() { }

        public CBAdas(int ora, int perc, int db, string nev) {

            AdasIdejeOra = ora;
            AdasIdejePerc = perc;
            AdasSzam = db;
            SoforNev = nev;
        }











    }
}
