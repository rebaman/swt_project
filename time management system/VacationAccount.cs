using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeitmanagement_System.time_management_system {
    class VacationAccount {

        //Attribute:
        private DateTime year;
        private uint vacEntitlement;
        private int vacBalance;


        //Methoden:
        public DateTime Year { 
            get => year; 
            set => year = value; 
        }
        
        public uint VacEntitlement { 
            get => vacEntitlement; 
            set => vacEntitlement = value; 
        }
        
        public int VacBalance { 
            get => vacBalance; 
            set => vacBalance = value; 
        }

    }
}
