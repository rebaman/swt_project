using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace PromilleApp{
    enum geschlecht {
        // Verteilungsfaktor im Körper (0,7 für Männer / 0,6 für Frauen)
        maennlich,
        weiblich,
        divers
    };
    class Person{
        public string Benutzername { get; set; }
        public geschlecht Geschlecht {get; set; }
        public int Gewicht {get; set;}
        public int Groesse {get; set;}
        public DateTime Geburtstag {get; set;}
        public Person(){}
        public Person(string benutzername, geschlecht geschlecht, int gewicht, int groesse, DateTime geburtstag)
        {
            this.Benutzername = benutzername;
            this.Geschlecht = geschlecht;
            this.Gewicht = gewicht;
            this.Groesse = groesse;
            this.Geburtstag = geburtstag;
        }

        public Person(Person r)
        {
            this.Benutzername = r.Benutzername;
            this.Geschlecht = r.Geschlecht;
            this.Gewicht = r.Gewicht;
            this.Groesse = r.Groesse;
            this.Geburtstag = r.Geburtstag;
        }

        public string toStringWithSemicolon()
        {
            string rtnString = this.Benutzername + "," + this.Geschlecht.ToString() + "," + this.Gewicht.ToString() + "," + this.Groesse.ToString() + "," + this.Geburtstag.ToString("o") + Environment.NewLine;
            return rtnString;
        }
        public static string headerStringWithSemicolon()
        {
            string rtnString = "Benutzername,Geschlecht,Gewicht,Groesse,Geburtstag" + Environment.NewLine;
            return rtnString;
        }
    }



    static class Globals
    {
        public static Person aktuellerBenutzer { get; set; }
        public static List<Person> personen { get; set; }
        public static void personenNeuEinlesen()
        {
            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\PromilleRechner\\Benutzer.csv";
            using (var reader = new StreamReader(filepath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var record = new Person();
                var records = csv.EnumerateRecords(record);
                foreach (var r in records)
                {
                    personen.Add(new Person(r));
                }
            }
        }
        static Globals()
        {
            personen = new List<Person>();
            aktuellerBenutzer = new Person();
        }
        public static bool personExistiert(string pers)
        {
            foreach (var r in personen)
            {
                if(r.Benutzername == pers)
                {
                    return true;
                }
            }
            return false;
        }
    }
}