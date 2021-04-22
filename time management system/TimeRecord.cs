using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeitmanagement_System.time_management_system {
    class TimeRecord {

        //Attribute:
        private DateTime datum;          // Date ging nicht 
        private DateTime startOfWork;
        private DateTime endOfWork;
        private DateTime workingHours;
        private string absenceReason;
        private bool approvalStatus = false;
        private bool recordLocked = false;

        private static ProjectEntry[] projects = new ProjectEntry[10];      //sollte evtl. anderswo spezifiziert werden! 


        //Methoden:
        public bool ApprovalStatus { 
            get => approvalStatus; 
            set => approvalStatus = value; 
        }

        public bool RecordLocked { 
            get => recordLocked; 
            set => recordLocked = value; 
        }

        public DateTime Datum { 
            get => datum; 
            set => datum = value; 
        }

        public DateTime StartOfWork { 
            get => startOfWork; 
            set => startOfWork = value; 
        }

        public DateTime EndOfWork { 
            get => endOfWork; 
            set => endOfWork = value; 
        }

        public DateTime WorkingHours { 
            get => workingHours; 
            set => workingHours = value; 
        }

        public string AbsenceReason { 
            get => absenceReason; 
            set => absenceReason = value; 
        }

        internal static ProjectEntry[] Projects { 
            get => projects; 
            set => projects = value; 
        }


    }
}
