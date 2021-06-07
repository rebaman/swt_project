using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromilleApp
{
    public partial class Vorlage : Form
    {
        public Vorlage()
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
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new NeuerEintrag();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new NeuerBenutzer();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm = new AnpassenBenutzer();
            frm.Show();
            this.Hide();
        }

        private void Vorlage_Shown(object sender, EventArgs e)
        {
            GetraenkeListe.getraenke.Add(new Getraenk("Bier", 500, 0.05));
            GetraenkeListe.getraenke.Add(new Getraenk("Starkbier", 500, 0.06));
            GetraenkeListe.getraenke.Add(new Getraenk("Weißwein", 250, 0.115));
            GetraenkeListe.getraenke.Add(new Getraenk("Rotwein", 250, 0.125));
            GetraenkeListe.getraenke.Add(new Getraenk("Sekt", 100, 0.125));
            GetraenkeListe.getraenke.Add(new Getraenk("Weinschorle", 200, 0.055));
            GetraenkeListe.getraenke.Add(new Getraenk("Rum", 20, 0.4));
            GetraenkeListe.getraenke.Add(new Getraenk("Gin", 20, 0.4));
            GetraenkeListe.getraenke.Add(new Getraenk("Vodka", 20, 0.4));
            GetraenkeListe.getraenke.Add(new Getraenk("Whisky", 20, 0.43));
            GetraenkeListe.getraenke.Add(new Getraenk("Scotch", 20, 0.43));
            GetraenkeListe.getraenke.Add(new Getraenk("Tequila", 20, 0.4));
            GetraenkeListe.getraenke.Add(new Getraenk("Longdrink", 200, 0.05));
            GetraenkeListe.getraenke.Add(new Getraenk("Cocktail", 300, 0.05));

            Form frm;
            Globals.personenNeuEinlesen();
            if(Globals.personen.Count > 0)
            {
                Globals.aktuellerBenutzer = Globals.personen.First();
                frm = new Uebersicht();
            }
            else
            {
                frm = new NeuerBenutzer();
            }
            frm.Show();
            this.Hide();
        }
    }
}
