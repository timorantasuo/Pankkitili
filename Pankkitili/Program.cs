using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pankkitili
{
    class Pankkitili
    {
        string omistaja;
        string tili;
        int saldo;

        public void nayta_tilin_tiedot()
        {
            Console.WriteLine("Tilin "+tili+", "+omistaja+" tiedot");
            Console.WriteLine("Saldo: " + saldo + "e");
            Console.WriteLine("----------------------------------");
        }


        public void talleta_rahaa()
        {

        }

        public void nosta_rahaa()
        {

        }

        public void siirra_rahaa_tilille()
        {

        }


        static void Main(string[] args)
        {
            Pankkitili formula;

            formula = new Pankkitili();

            formula.tili = ("CH12 5476 6699 1536 35");
            formula.omistaja = ("Rimi Käikkönen");
            formula.saldo = 45888;

            formula.nayta_tilin_tiedot();

            Pankkitili koodari;

            koodari = new Pankkitili();

            koodari.omistaja = ("Jördekurren");
            koodari.tili = ("SV55 4854 4813 1552 14");
            koodari.saldo = 198111;

            koodari.nayta_tilin_tiedot();

            Console.ReadKey();
        }
    }
}
