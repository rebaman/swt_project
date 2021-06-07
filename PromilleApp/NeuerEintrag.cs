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
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ausgewaehltesGetraenk = GetraenkeListe.getraenke[comboBoxGetraenk.SelectedIndex];
            textBoxVolumen.Text = ausgewaehltesGetraenk.verzehrteMenge.ToString();
            textBoxVolumen.Select();
            //textBox1.SelectAll();
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
    }
}
