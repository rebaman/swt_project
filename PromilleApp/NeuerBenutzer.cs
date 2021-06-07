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
using System.IO;

namespace PromilleApp
{
    public partial class NeuerBenutzer : Form
    {
        public NeuerBenutzer()
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new NeuerEintrag();
            frm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm = new AnpassenBenutzer();
            frm.Show();
            this.Close();
        }

        private void buttonAnlegen_Click(object sender, EventArgs e)
        {
            Person user;
            geschlecht gesch;
            //-- Prüfen ob alle Felder ausgefüllt wurden
            if(textBoxBenutzerName.Text != "" && textBoxGewicht.Text != "" && textBoxGroesse.Text != "" && comboBoxGeschlecht.Text != "auswählen")
            {
                if (!Globals.personExistiert(textBoxBenutzerName.Text))
                {
                    switch (comboBoxGeschlecht.Text)    //-- Parsen von Comboboxinhalt auf Aufzählungsdatentyp
                    {
                        case "männlich":
                            gesch = geschlecht.maennlich;
                            break;
                        case "weiblich":
                            gesch = geschlecht.weiblich;
                            break;
                        case "divers":
                            gesch = geschlecht.divers;
                            break;
                        default:
                            MessageBox.Show("Kein passendes Geschlecht gefunden!");
                            Application.Exit();
                            gesch = geschlecht.maennlich;
                            break;

                    }
                    //-- User Instanz initialisieren
                    user = new Person(textBoxBenutzerName.Text, gesch, Int32.Parse(textBoxGewicht.Text), Int32.Parse(textBoxGroesse.Text), dateTimePickerGeburtstag.Value);
                    //-- %appdata% Pfad abfragen
                    string filePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\PromilleRechner\\";
                    string fileName = "Benutzer.csv";
                    File.AppendAllText(filePath + fileName, user.toStringWithSemicolon());
                    Globals.personenNeuEinlesen();
                    Globals.aktuellerBenutzer = user;

                    Form frm = new Uebersicht();
                    frm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Benutzername existiert bereits");
                }
            }
            else
            {
                MessageBox.Show("Nicht alle Felder ausgefüllt");
            }
        }

        private void buttonVerwerfen_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Wollen Sie wirklich alle Eingaben verwerfen?", "Eingaben verwerfen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                Form frm = new Uebersicht();
                frm.Show();
                this.Close();
            }
        }

        private void textBoxBenutzerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //-- Erlaubt nur Zahlen, Buchstaben, Leerzeichen und Unterstriche
            var regex = new Regex(@"[^a-zA-Z0-9_\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void NeuerBenutzer_Load(object sender, EventArgs e)
        {
            //-- Initialsiert die Combobox mit Defaultwert
            comboBoxGeschlecht.Text = "auswählen";
        }

        private void textBoxAlter_KeyPress(object sender, KeyPressEventArgs e)
        {
            //-- Erlaubt nur Zahlen
            var regex = new Regex(@"[^0-9\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void textBoxGewicht_KeyPress(object sender, KeyPressEventArgs e)
        {
            //-- Erlaubt nur Zahlen
            var regex = new Regex(@"[^0-9\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void textBoxGroesse_KeyPress(object sender, KeyPressEventArgs e)
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
