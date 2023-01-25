using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Zad
{
    internal class Program
    {
        class NebeskoTijelob
        {
            double BrzinaOkoOsi, BrzinaOkoSunca;

            public NebeskoTijelob()
            {

            }
            public NebeskoTijelob(double BrzinaOkoOsi, double BrzinaOkoSunca)
            {
                this.BrzinaOkoOsi = BrzinaOkoOsi;
                this.BrzinaOkoSunca = BrzinaOkoSunca;
            }
        }
        class Planet : NebeskoTijelob
        {
            public Planet(double BrzinaOkoOsi, double BrzinaOkoSunca) : base(BrzinaOkoOsi, BrzinaOkoSunca)
            {
               
            }
        }
        class Satelit : NebeskoTijelob
        {
            public Satelit(double BrzinaOkoOsi, double BrzinaOkoSunca) : base(BrzinaOkoOsi, BrzinaOkoSunca)
            {

            }
        }
        static void Main(string[] args)
        {
            /*Definirajte klasu NebeskoTijelo sa sljedećim varijablama članicama:
            • varijable tipa double
            BrzinaOkoOsi 
            BrzinaOkoSunca 
            Definirajte klase Planet i Satelit izvedene iz klase NebeskoTijelo, te im definirajte sljedeće 
            konstruktore:
            Planet(double, double) 
            Satelit(double, double) 
            koji će dodijeliti vrijednosti proslijeđenih argumenata naslijeđenim varijablama članicama
            Definirajte dva objekta Zemlja i Mjesec tipova Planet i Satelit.*/

            Planet Zemlja = new Planet(1, 1);
            Satelit Mjesec = new Satelit(1, 1);

            Console.ReadKey();
        }
    }
}
