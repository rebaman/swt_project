using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace PromilleApp
{
     class Getraenk
    {
        public string name { get; set; }
        public int verzehrteMenge { get; set; }
        public double volumenProzent { get; set; }
        public Getraenk(string n, int m, double p)
        {
            name = n;
            verzehrteMenge = m;
            volumenProzent = p;
        }
    }
    static class GetraenkeListe
    {
        public static List<Getraenk> getraenke = new List<Getraenk>();
    }
}
