using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeitmanagement_System.time_management_system {
    class ProjectEntry {

        //Attribute:
        private string projectId;
        private DateTime investedTime;



        //Methoden:
        public string ProjectId {
            get => projectId; 
            set => projectId = value; 
        }

        public DateTime InvestedTime {
            get => investedTime; 
            set => investedTime = value; 
        }


    }
}
