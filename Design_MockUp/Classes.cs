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
    class ProjektEntry
    {
        private string projectId { get; set; }
        private int investedTime { get; set; }
}
    class VacationAccount
    {
        private int year { get; set; }
        private int vacationEntitlement { get; set; }
        private int vacationBalance { get; set; }
    }
    class TimeRecord
    {
        private DateTime workdayDate { get; set; }
        private string absenceReason { get; set; }
        private DateTime startOfWork { get; set; }
        private DateTime endOfWork { get; set; }
        private int workingHours { get; set; }
        private bool approvalStatus { get; set; }
        private bool recordLocked { get; set; }
        private List<ProjektEntry> projektEntries { get; set; }
    }
    class WorkingTimeAccount
    {
        private int flextimeBalance { get; set; }
        private int dailyTargetWorktime { get; set; }
        private List<TimeRecord> timeRecords { get; set; }
        private List<VacationAccount> vacationAccounts { get; set; }
    }
    class Employee
    {
        private int staffId { get; set; }
        private string name { get; set; }
        private string password { get; set; }
        private string departmentId { get; set; }
        private WorkingTimeAccount workingTimeAccount { get; set; }
        Employee(int staffId)
        {

        }
    }
}
