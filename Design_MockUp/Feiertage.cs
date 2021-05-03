using System;
using System.Collections.Generic;
using System.Text;

namespace thorstenhans.Utilities
{
    public class Feiertag : IComparable<Feiertag>
    {
        private bool isFix;
        private DateTime datum;
        private string name;

        public Feiertag(bool isFix, DateTime datum, string name)
        {
            this.IsFix = isFix;
            this.Datum = datum;
            this.Name = name;

        }

        /// <summary>
        /// Beschreibung: 
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }


        /// <summary>
        /// Beschreibung: 
        /// </summary>
        public DateTime Datum
        {
            get
            {
                return datum;
            }
            set
            {
                datum = value;
            }
        }


        /// <summary>
        /// Beschreibung: 
        /// </summary>
        public bool IsFix
        {
            get
            {
                return isFix;
            }
            set
            {
                isFix = value;
            }
        }


        #region IComparable<Feiertag> Member

        public int CompareTo(Feiertag other)
        {
            return this.datum.Date.CompareTo(other.datum.Date);
        }

        #endregion
    }
    public class FeiertagLogic
    {
        private static FeiertagLogic Instance;
        private List<Feiertag> feiertage;
        private int year;

        /// <summary>
        /// Beschreibung: 
        /// </summary>
        public int CurrentYear
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }

        public static FeiertagLogic GetInstance(int year)
        {
            if (Instance == null || year != Instance.CurrentYear)
            {
                Instance = new FeiertagLogic(year);
                return Instance;
            }
            return Instance;
        }

        /// <summary>
        /// Beschreibung: Gibt variable Feiertage zurueck
        /// </summary>
        public List<Feiertag> VariableFeiertage
        {
            get
            {
                return feiertage.FindAll(delegate (Feiertag f) { return !f.IsFix; });
            }

        }

        public bool isFeiertag(DateTime value)
        {
            return (feiertage.Find(delegate (Feiertag f) { return f.Datum.Date == value.Date; }) != null);
        }

        public Feiertag GetFeiertagName(DateTime value)
        {
            return (feiertage.Find(delegate (Feiertag f) { return f.Datum.Date == value.Date; }));
        }
        /// <summary>
        /// Beschreibung: gibt feste Feiertage zurueck
        /// </summary>
        public List<Feiertag> FesteFeiertage
        {
            get
            {
                return feiertage.FindAll(delegate (Feiertag f) { return f.IsFix; });
            }
        }

        private FeiertagLogic(int year)
        {
            this.CurrentYear = year;
            #region fillList
            this.feiertage = new List<Feiertag>();
            this.feiertage.Add(new Feiertag(true, new DateTime(year, 1, 1), "Neujahr"));
            this.feiertage.Add(new Feiertag(true, new DateTime(year, 1, 6), "Heilige Drei Könige"));
            this.feiertage.Add(new Feiertag(true, new DateTime(year, 5, 1), "Tag der Arbeit"));
            //this.feiertage.Add(new Feiertag(true, new DateTime(year, 8, 15), "Mariä Himmelfahrt"));
            this.feiertage.Add(new Feiertag(true, new DateTime(year, 10, 3), "Tag der dt. Einheit"));
            //this.feiertage.Add(new Feiertag(true, new DateTime(year, 10, 31), "Reformationstag"));
            this.feiertage.Add(new Feiertag(true, new DateTime(year, 11, 1), "Allerheiligen "));
            this.feiertage.Add(new Feiertag(true, new DateTime(year, 12, 25), "1. Weihnachtstag"));
            this.feiertage.Add(new Feiertag(true, new DateTime(year, 12, 26), "2. Weihnachtstag"));
            DateTime osterSonntag = GetOsterSonntag();
            this.feiertage.Add(new Feiertag(false, osterSonntag, "Ostersonntag"));
            //this.feiertage.Add(new Feiertag(false, osterSonntag.AddDays(-3), "Gründonnerstag"));
            this.feiertage.Add(new Feiertag(false, osterSonntag.AddDays(-2), "Karfreitag"));
            this.feiertage.Add(new Feiertag(false, osterSonntag.AddDays(1), "Ostermontag"));
            this.feiertage.Add(new Feiertag(false, osterSonntag.AddDays(39), "Christi Himmelfahrt"));
            this.feiertage.Add(new Feiertag(false, osterSonntag.AddDays(49), "Pfingstsonntag"));
            this.feiertage.Add(new Feiertag(false, osterSonntag.AddDays(50), "Pfingstmontag"));
            this.feiertage.Add(new Feiertag(false, osterSonntag.AddDays(60), "Fronleichnam"));


            #endregion
        }

        private DateTime GetOsterSonntag()
        {

            int g, h, c, j, l, i;

            g = year % 19;
            c = this.year / 100;
            h = ((c - (c / 4)) - (((8 * c) + 13) / 25) + (19 * g) + 15) % 30;
            i = h - (h / 28) * (1 - (29 / (h + 1)) * ((21 - g) / 11));
            j = (year + (year / 4) + i + 2 - c + (c / 4)) % 7;

            l = i - j;
            int month = (int)(3 + ((l + 40) / 44));
            int day = (int)(l + 28 - 31 * (month / 4));

            return new DateTime(year, month, day);

        }
    }
}