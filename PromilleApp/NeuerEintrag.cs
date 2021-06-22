using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromilleApp
{
    public partial class NeuerEintrag : Form
    {
        Getraenk ausgewaehltesGetraenk;
        EintraegeListe listeMitEintraegen = new EintraegeListe();
        double gesamtAlkoholMenge;
        double promille;

        public NeuerEintrag()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new Uebersicht();
            frm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new NeuerBenutzer();
            frm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm = new AnpassenBenutzer();
            frm.Show();
            this.Close();
        }

        private void NeuerEintrag_Load(object sender, EventArgs e)
        {
            if (Globals.personen.Count() > 0)
            {
                comboBox1.Items.Clear();
                foreach (var r in Globals.personen)
                {
                    this.comboBox1.Items.Add(r.Benutzername);
                }
                comboBox1.SelectedIndex = Globals.personen.IndexOf(Globals.aktuellerBenutzer);
            }
            foreach(var g in GetraenkeListe.getraenke)
            {
                comboBoxGetraenk.Items.Add(g.name);
            }
            comboBoxGetraenk.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var r in Globals.personen)
            {
                if (r.Benutzername == comboBox1.Text)
                {
                    Globals.aktuellerBenutzer = r;
                }
            }
            listeMitEintraegen.eintraege.Clear();
            gesamtAlkoholMenge = 0;
            listView1_aktualisieren();
            labelNuechtern.Text = "";
            labelFahren.Text = "";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ausgewaehltesGetraenk = GetraenkeListe.getraenke[comboBoxGetraenk.SelectedIndex];
            textBoxVolumen.Text = ausgewaehltesGetraenk.defaultVerzehrMenge.ToString();
            textBoxVolumen.Select();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //-- Erlaubt nur Zahlen
            var regex = new Regex(@"[^0-9\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void buttonHinzufuegen_Click(object sender, EventArgs e)
        {
            Getraenk gefunden =  GetraenkeListe.getraenke.Find(x => x.name == comboBoxGetraenk.Text);
            listeMitEintraegen.eintraege.Add(new Eintrag(gefunden.name, Int32.Parse(textBoxVolumen.Text), Int32.Parse(textBoxVolumen.Text) * gefunden.volumenProzent * 0.8));
            listView1_aktualisieren();
        }

        private void listView1_aktualisieren()
        {
            listViewGetraenke.Items.Clear();
            gesamtAlkoholMenge = 0.0;
            string[] row;
            ListViewItem lvi;
            foreach (var e in listeMitEintraegen.eintraege)
            {
                row = new string[] { e.name, e.verzehrteMenge.ToString(), e.alkoholMenge.ToString() };
                lvi = new ListViewItem(row);
                lvi.Tag = e;
                listViewGetraenke.Items.Add(lvi);
                gesamtAlkoholMenge += e.alkoholMenge;
            }
            textBox1.Text = gesamtAlkoholMenge.ToString("0.0");
            promilleBerechnen();
        }
        private void promilleBerechnen()
        {
            int stundenBisNuechtern;
            double gesamtkoerperwasser;
            int alter = DateTime.Now.Year - Globals.aktuellerBenutzer.Geburtstag.Year;
            Globals.aktuellerBenutzer.Geburtstag = Globals.aktuellerBenutzer.Geburtstag.AddYears(alter);
            if (DateTime.Now.CompareTo(Globals.aktuellerBenutzer.Geburtstag) < 0) { alter--; }
            if (Globals.aktuellerBenutzer.Geschlecht == geschlecht.maennlich || Globals.aktuellerBenutzer.Geschlecht == geschlecht.divers)
            {
                gesamtkoerperwasser = 2.447 - 0.09516 * alter + 0.1074 * Globals.aktuellerBenutzer.Groesse + 0.3362 * Globals.aktuellerBenutzer.Gewicht;
            }
            else
            {
                gesamtkoerperwasser = 0.203 - 0.07 * alter + 0.1069 * Globals.aktuellerBenutzer.Groesse + 0.2466 * Globals.aktuellerBenutzer.Gewicht;
            }
            double verteilungsfaktor = (1.055 * gesamtkoerperwasser) / (0.8 * Globals.aktuellerBenutzer.Gewicht);
            promille = gesamtAlkoholMenge / (Globals.aktuellerBenutzer.Gewicht * verteilungsfaktor);
            textBox2.Text = promille.ToString("0.00");
            if (Globals.aktuellerBenutzer.Geschlecht == geschlecht.maennlich || Globals.aktuellerBenutzer.Geschlecht == geschlecht.divers)
            {
                stundenBisNuechtern = Convert.ToInt32(Math.Ceiling(promille / 0.15));
            }
            else
            {
                stundenBisNuechtern = Convert.ToInt32(Math.Ceiling(promille / 0.13));
            }
            if (stundenBisNuechtern > 0)
            {
                DateTime zeitpunkt = DateTime.Now.AddHours(stundenBisNuechtern);
                labelNuechtern.Text = "Nüchtern am: " + zeitpunkt.ToShortDateString() + " " + zeitpunkt.ToLongTimeString();
            }
        }

        private void buttonLoeschen_Click(object sender, EventArgs e)
        {
            if (listViewGetraenke.SelectedItems.Count == 1)
            {
                listeMitEintraegen.eintraege.RemoveAt(listViewGetraenke.SelectedItems[0].Index);
                listView1_aktualisieren();
            }
        }
    }
}
