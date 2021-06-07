using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PromilleApp
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
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\PromilleRechner\\";
            string fileName = "Benutzer.csv";
            //-- Falls nicht vorhanden erstellen des Ordners
            System.IO.Directory.CreateDirectory(filePath);
            //-- Prüfen ob Datei bereits existiert, ansonsten anlegen
            if (!File.Exists(filePath + fileName))
            {
                File.WriteAllText(filePath + fileName, Person.headerStringWithSemicolon());
            }
            Application.Run(new Vorlage());
        }
    }
}
