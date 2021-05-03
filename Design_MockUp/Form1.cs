using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Syncfusion.WinForms.Input;
using thorstenhans.Utilities;
using System.Data.OleDb;

namespace Design_MockUp
{
    public partial class Form1 : Form
    {
        static Employee user;

        public Form1(int userId) 
        {
            fillUpClasses(userId);            
            InitializeComponent();
            radioButtonArbeitend.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radioButtonKrank.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radioButtonUrlaub.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radioButtonZeitausgleich.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            LabelEmployeeName.Text = user.Name;

        }
        private void fillUpClasses(int userId)
        {
            fillUpEmployee(userId);
            fillUpWorkingTimeAccount();
            fillUpTimeRecords();
        }
        private void fillUpEmployee(int userId)
        {
            OleDbCommand cmd = DbAccess.con.CreateCommand();
            cmd.CommandText = "SELECT employee_name FROM Employee WHERE ID=" + userId;
            cmd.Connection = DbAccess.con;

            DbAccess.con.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                user = new Employee(userId, reader.GetString(0));
            }
            reader.Close();
            DbAccess.con.Close();
        }
        private void fillUpWorkingTimeAccount()
        {
            OleDbCommand cmd = DbAccess.con.CreateCommand();
            cmd.CommandText = "SELECT * FROM WorkingTimeAccount WHERE staffId=" + user.StaffId;
            cmd.Connection = DbAccess.con;

            DbAccess.con.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                user.WorkingTimeAccount = new WorkingTimeAccount(reader.GetInt32(1), reader.GetInt32(2));//(Int32.Parse(reader[1].ToString()), Int32.Parse(reader[2].ToString()));
            }
            reader.Close();
            DbAccess.con.Close();
        }
        private void fillUpTimeRecords()
        {
            user.WorkingTimeAccount.TimeRecords = new List<TimeRecord>();
            OleDbCommand cmd = DbAccess.con.CreateCommand();
            cmd.CommandText = "SELECT * FROM TimeRecord WHERE staffId=" + user.StaffId;
            cmd.Connection = DbAccess.con;

            DbAccess.con.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if(reader[4].ToString() != "")
                {
                    user.WorkingTimeAccount.TimeRecords.Add(new TimeRecord(reader.GetDateTime(1), reader[4].ToString()));
                }
                else
                {
                    user.WorkingTimeAccount.TimeRecords.Add(new TimeRecord(reader.GetDateTime(1), reader.GetDateTime(2), reader.GetDateTime(3), ""));
                }
            }
            reader.Close();
            DbAccess.con.Close();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            sfCalendar1.TrailingDatesVisible = false;
            sfCalendar1.ShowNone = false;
            sfCalendar1.ShowFooter = true;
            sfCalendar1.MinDate = new DateTime(2021, 1, 01);
            sfCalendar1.MaxDate = new DateTime(2099, 12, 31);
            markup_sfCalender1();
            sfCalendar1.SelectedDate = DateTime.Today;
            groupBoxMitarbeiter.Text = sfCalendar1.SelectedDate.Value.ToString("d");
        }

        private void markup_sfCalender1()
        {
            DateTime today = DateTime.Today;
            
            List<SpecialDate> SpecialDates = new List<SpecialDate>();
            for (int year = sfCalendar1.MinDate.Year; year <= sfCalendar1.MaxDate.Year; year++)
            {
                for (var date = new DateTime(year, 1, 01); date <= new DateTime(year, 12,31); date = date.AddDays(1))
                {
                    FeiertagLogic germanHolidays = FeiertagLogic.GetInstance(year);
                    if (germanHolidays.isFeiertag(date))
                    {
                        SpecialDate specialDate = new SpecialDate();
                        specialDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
                        specialDate.ForeColor = System.Drawing.Color.Black;
                        specialDate.BackColor = System.Drawing.Color.LightGreen;
                        specialDate.Value = date;
                        SpecialDates.Add(specialDate);
                    }
                    else if (date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday)
                    {
                        SpecialDate specialDate = new SpecialDate();
                        specialDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
                        specialDate.ForeColor = System.Drawing.Color.Black;
                        specialDate.BackColor = System.Drawing.Color.LightSteelBlue;
                        specialDate.Value = date;
                        SpecialDates.Add(specialDate);
                    }
                }
            }
            sfCalendar1.SpecialDates = SpecialDates;
        }

        private void sfCalendar1_SelectionChanged(SfCalendar sender, Syncfusion.WinForms.Input.Events.SelectionChangedEventArgs e)
        {
            groupBoxMitarbeiter.Text = sfCalendar1.SelectedDate.Value.ToString("d");
            TimeRecord tr = user.WorkingTimeAccount.TimeRecords.Find(x => x.WorkdayDate == sfCalendar1.SelectedDate);
            if(tr != null)
            {
                if(tr.AbsenceReason != "")
                {
                    switch (tr.AbsenceReason)
                    {
                        case "ZA":
                            radioButtonZeitausgleich.Checked = true;
                            break;
                        case "U":
                            radioButtonUrlaub.Checked = true;
                            break;
                        case "K":
                            radioButtonKrank.Checked = true;
                            break;
                        default:
                            MessageBox.Show("Unbekannter Abwesendheitsgrund!\n" + tr.AbsenceReason);
                            break;
                    }
                }
                else
                {
                    radioButtonArbeitend.Checked = true;
                    timePickerKommen.Value = tr.StartOfWork;
                    timePickerGehen.Value = tr.EndOfWork;
                }
            }
        }
    }
}
