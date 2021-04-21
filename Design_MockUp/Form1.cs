using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_MockUp
{
    public partial class Form1 : Form
    {
        public Form1(int staffId)
        {
            InitializeComponent();
            radioButtonArbeitend.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radioButtonKrank.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radioButtonUrlaub.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radioButtonZeitausgleich.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
        }

        private void radioButtons_CheckedChanged (object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButtonArbeitend.Checked)
            {
                timePickerGehen.Enabled = true;
                labelGehen.Enabled = true;
                timePickerKommen.Enabled = true;
                labelKommen.Enabled = true;
            }
            else
            {
                timePickerGehen.Value = new DateTime(2000, 1, 1, 16, 0, 0);
                timePickerKommen.Value = new DateTime(2000, 1, 1, 8, 0, 0);
                timePickerGehen.Enabled = false;
                timePickerKommen.Enabled = false;
                labelGehen.Enabled = false;
                labelKommen.Enabled = false;
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            groupBoxMitarbeiter.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBoxMitarbeiter.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
        }
    }
}
