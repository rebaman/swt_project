using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Design_MockUp
{
    class TimeRecord
    {
        private DateTime workdayDate;
        private string absenceReason;
        private DateTime startOfWork;
        private DateTime endOfWork;

        public DateTime WorkdayDate { get; set; }
        public string AbsenceReason { get; set; }
        public DateTime StartOfWork { get; set; }
        public DateTime EndOfWork { get; set; }
        public TimeRecord(DateTime workdayDate, DateTime startOfWork, DateTime endOfWork, string absenceReason)
        {
            this.workdayDate = workdayDate;            
            this.startOfWork = startOfWork;
            this.endOfWork = endOfWork;
            this.absenceReason = absenceReason;
        }
        public TimeRecord(DateTime workdayDate, string absenceReason)
        {
            this.workdayDate = workdayDate;
            this.absenceReason = absenceReason;
        }
    }
    class WorkingTimeAccount
    {
        private int flextimeBalance;
        private int dailyTargetWorktime;
        private List<TimeRecord> timeRecords;
        public int FlextimeBalance { get; set; }
        public int DailyTargetWorktime { get; set; }
        public List<TimeRecord> TimeRecords { get; set; }
        public WorkingTimeAccount(int flextimeBalance, int dailyTargetWorktime)
        {
            this.flextimeBalance = flextimeBalance;
            this.dailyTargetWorktime = dailyTargetWorktime;
        }
    }
    class Employee
    {
        private int staffId;
        private string name;
        private WorkingTimeAccount workingTimeAccount;
        public int StaffId 
        {
            get { return staffId; }
            set { staffId = value; } 
        }
        public string Name 
        {
            get { return name; }
            set { name = value; } 
        }
        public WorkingTimeAccount WorkingTimeAccount 
        {
            get { return workingTimeAccount; }
            set { workingTimeAccount = value; } 
        }
        public Employee(int staffId, string name)
        {
            this.staffId = staffId;
            this.name = name;
        }
    }
}
