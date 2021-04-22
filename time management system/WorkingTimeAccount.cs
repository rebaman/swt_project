using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Zeitmanagement_System.time_management_system {
    class WorkingTimeAccount {


        //Attribute:
        private DateTime flextimeBalance;
        private DateTime dailyTagetWorktime;
        private static TimeRecord[] timeRecords = new TimeRecord[31];                   // einer pro Monat?
        private static VacationAccount[] vacationAccounts = new VacationAccount[20];    //einer pro MA?

        //Methoden:
        public bool addTimeRecord(DateTime date,string absenceReason,DateTime startTime,DateTime endTime /* workingHours kann man berechnen!*/){
            TimeRecord tmp = new TimeRecord();
            /*
             * Funktionen adden zeug oder ctor wird aufgerufen.
             */
            return false;
        }
        
        public bool changeTimeRecord(DateTime date, string absenceReason, DateTime startTime, DateTime endTime /* workingHours kann man berechnen!*/,int i){
            if (timeRecords[i].RecordLocked == false){
                
                //apply changes:
                timeRecords[i].Datum = date;
                timeRecords[i].AbsenceReason = absenceReason;
                timeRecords[i].StartOfWork = startTime;
                timeRecords[i].EndOfWork = endTime;
                timeRecords[i].WorkingHours = Convert.ToDateTime(endTime.Subtract(startTime));
                return true;
            }
            else return false;
        }

        public bool deleteTimeRecord(DateTime date,int i){
            return (timeRecords[i].Datum == date ? false : true);
        }

        public bool duplicateCheck(DateTime date){
            return (timeRecords[].Datum == date ? false : true);
        }


        //Ctor:
        public WorkingTimeAccount(DateTime _flextimeBalance,DateTime _dailyWorktime){

        }

    }
}
