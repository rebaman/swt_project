using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace time_management_system
{
    public class Employee
    {
        //Variablen:
        private float[] tagesarbeitszeit = new float[] {0.0f,0.0f,0.0f,8.0f,0.0f}; // kommen, gehen, pause, soll,gesamt;

        private float gleitzeitstand;
        private uint vacdays = 30;
        private uint sickdays = 0;

        private string name;

        

        //Methoden:
        public string Name {
            get => name; 
            set => name = value; 
        }

        public float Gleitzeitstand { 
            get => gleitzeitstand; 
            set => gleitzeitstand = value; 
        }

        public uint Vacdays { 
            get => vacdays; 
            set => vacdays = value; 
        }

        public uint Sickdays { 
            get => sickdays; 
            set => sickdays = value; 
        }
        public float[] Tagesarbeitszeit { 
            get => tagesarbeitszeit; 
            set => tagesarbeitszeit = value; }

       

        //Konstruktor(en)
        public Employee(string Name){
            gleitzeitstand = 0.0f;
            if (Name != null){
                name = Name;
            }
            tagesarbeitszeit[3] = 8f;

        }
    }
}
