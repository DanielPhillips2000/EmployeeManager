using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EmployeeManager
{
    class Employee
    {
        public Employee(string eName, int eID, int eHoursWorked)
        {
            EmployeeName = eName;
            EmployeeID = eID;
            HoursWorked = eHoursWorked;
            HourlyRate = 9.5;
            
        }

        
        public string ToString(Employee e)
        {
            string ToString = (e.EmployeeName + " " + e.EmployeeID);

            return ToString;
        }
        public static double Overtime(double EhoursWorked, double EhourlyRate, double EOvertimeRate)
        {
            if (EhoursWorked < 40)
            {
                return EhoursWorked * EhourlyRate;
            }
            else
            {
                return ((EhoursWorked - 40) * EOvertimeRate) + (40 * EhourlyRate);
            }

        }
        public static Boolean HoursVal(double eHoursWorked)
        {
            if (eHoursWorked < 1)
            {
                return false;
                //Console.WriteLine("Invalid work hours please change");
                //EhoursWorked = Convert.ToDouble(Console.ReadLine());
            }
            else if (eHoursWorked > 100)
            {
                return false;
                //Console.WriteLine("Invalid work hours please change");
                //EhoursWorked = Convert.ToDouble(Console.ReadLine());
            }
            else
                return true;
        }
        public static Boolean IDVal(string eID)
        {
            if (eID.Length == 3)
            {
                string fID = eID.Substring(0);
                string sID = eID.Substring(1);
                string tID = eID.Substring(2);

                if (IsLetter.IsMatch(fID))
                {
                    if (IsNumber.IsMatch(sID))
                    {
                        if (IsNumber.IsMatch(tID))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
        static Regex IsNumber = new Regex(@"^[0-9]+$");
        static Regex IsLetter = new Regex(@"^[a-zA-Z]");

        public string EmployeeName { get; set; }
        public int EmployeeID { get; set; }
        public int HoursWorked { get; set; }
        public double HourlyRate { get; set; }

    }
}
