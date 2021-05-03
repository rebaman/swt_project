using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Design_MockUp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //connect();
            Application.Run(new Anmeldeoberflaeche());
            //Application.Run(new Form1(200100));
        }
        public static void connect()
        {
            string dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;";
            string dbSource = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\\\66.66.66.200\\Daniel\\10_Studium\\30_3_Semester\\60_Softwaretechnik\\30_Projekt\\Datenbank_ForschInst_BaWue.accdb";
            OleDbConnection con = new OleDbConnection(dbProvider+dbSource);
            
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO Employee (ID, employee_name) VALUES (200100, 'Daniel Osswald')";
            cmd.Connection = con;
            con.Open();
            
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Submitted", "Congrats");
            
            con.Close();
        }
    }
    class DbAccess
    {
        public static string dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;";
        public static string dbSource = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\\\66.66.66.200\\Daniel\\10_Studium\\30_3_Semester\\60_Softwaretechnik\\30_Projekt\\Datenbank_ForschInst_BaWue.accdb";
        public static OleDbConnection con = new OleDbConnection(dbProvider + dbSource);
    }
}