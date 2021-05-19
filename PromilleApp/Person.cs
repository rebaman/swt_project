using System;

namespace PromilleApp{
    enum geschlecht {
        // Verteilungsfaktor im Körper (0,7 für Männer / 0,6 für Frauen)
        männlich,
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
        public string toStringWithSemicolon()
        {
            string rtnString = this.Benutzername + ";" + this.Geschlecht.ToString() + ";" + this.Gewicht.ToString() + ";" + this.Groesse.ToString() + ";" + this.Geburtstag.ToShortDateString();
            return rtnString;
        }
    }
}