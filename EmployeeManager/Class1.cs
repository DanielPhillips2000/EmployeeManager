using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManager
{
    class Employee
    {
        public Employee(string eName, int eID, int eHoursWorked, int eHourlyRate)
        {
            EName = eName;
            EID = eID;
            EHoursWorked = eHoursWorked;
            EHourlyRate = eHourlyRate;
            
        }

        
        public string ToString(Employee e)
        {
            string ToString = (e.EName + " " + e.EID);

            return ToString;
        }

        public string EName { get; set; }
        public int EID { get; set; }
        public int EHoursWorked { get; set; }
        public int EHourlyRate { get; set; }

    }
}
