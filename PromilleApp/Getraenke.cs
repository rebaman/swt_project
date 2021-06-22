using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace PromilleApp
{
     class Getraenk
    {
        public string name { get; set; }
        public int defaultVerzehrMenge { get; set; }
        public double volumenProzent { get; set; }
        public Getraenk(string n, int m, double p)
        {
            name = n;
            defaultVerzehrMenge = m;
            volumenProzent = p;
        }
    }
    static class GetraenkeListe
    {
        public static List<Getraenk> getraenke = new List<Getraenk>();
    }

    class Eintrag
    {
        public string name { get; set; }
        public int verzehrteMenge { get; set; }
        public double alkoholMenge { get; set; }
        public Eintrag(string n, int m, double a)
        {
            name = n;
            verzehrteMenge = m;
            alkoholMenge = a;
        }
    }
    class EintraegeListe
    {
        public List<Eintrag> eintraege = new List<Eintrag>();
    }
}
