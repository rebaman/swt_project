using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Design_MockUp
{
    public partial class Anmeldeoberflaeche : Form
    {
        public Anmeldeoberflaeche()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(acceptedIDFormat(textBox1.Text))
            {
                OleDbCommand cmd = DbAccess.con.CreateCommand();
                cmd.CommandText = "SELECT * FROM Employee WHERE ID=" + Int32.Parse(textBox1.Text);
                cmd.Connection = DbAccess.con;

                DbAccess.con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                if (!reader.Read())
                {
                    MessageBox.Show("Benutzerkennung nicht gefunden!", "Error");
                    textBox1.Select();
                    textBox1.SelectAll();
                }
                else
                {
                    if (reader[2].ToString() == textBox2.Text)
                    {
                        reader.Close();
                        DbAccess.con.Close();
                        Form frm = new Form1(Int32.Parse(textBox1.Text));
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        reader.Close();
                        DbAccess.con.Close();
                        MessageBox.Show("Das Passwort oder die Benutzerkennung ist falsch!", "Error");
                        textBox2.Clear();
                        textBox2.Select();
                    }
                }
            }
            else
            {
                MessageBox.Show("Bitte geben Sie eine gültige Benutzerkennung ein!", "Error");
            }
        }
        bool acceptedIDFormat(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
    }
}
