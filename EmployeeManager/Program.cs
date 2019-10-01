using System;

namespace EmployeeManager
{
    class Program
    {
        public string strHoursWorked;
        
        

        static void Main(string[] args)
        {
            var employee = new Employee();
            Console.WriteLine("Please enter number of hours worked");
            employee.HoursWorked = Convert.ToDouble(Console.ReadLine());

            while (HoursVal(employee.HoursWorked) == false)
            {
                Console.WriteLine("Value entered invalid, please enter new value.");
                employee.HoursWorked = Convert.ToDouble(Console.ReadLine());

            }

            Console.WriteLine("Please Enter Name");
            employee.EmployeeName = Console.ReadLine();



            Console.WriteLine("Please Enter ID");
            employee.EmployeeID = Console.ReadLine();


            Console.WriteLine("Emloyee Name: " + employee.EmployeeName);
            Console.WriteLine("Employee ID: " + employee.EmployeeID);
            Console.WriteLine("Hours Worked: " + employee.HoursWorked);


            Console.WriteLine("Weekly Wage: " + Convert.ToDecimal(string.Format("{0:F2}", Overtime(employee.HoursWorked, employee.HourlyRate, employee.OvertimeRate))));

        }

        public class Employee
        {
            public string EmployeeName { get; set; }
            public string EmployeeID { get; set;  }
            public double HoursWorked { get; set; }
            public double HourlyRate = 9.5;
            public double OvertimeRate = 14.25;
            //public double WeeklyWage { get { return HoursWorked * HourlyRate; } }
            
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
            if( eID.Length == 3)
            {
                int fID = Convert.ToInt32(eID.Substring(0,0));
                string sID = eID.Substring(1, 1);
                string tID = eID.Substring(2, 2);

                //if (Char.(fID) );
                //{
                //    if (sID != ) ;
                //    {
                //        if (fID != ) ;
                //        {

                //            return true;
                //        }
                //        else
                //        {
                //            return false;
                //        }
                //    }
                //    else
                //    {
                //        return false;
                //    }
                //}
                //else
                //{
                //    return false;
                //}
                
            }
            else
            {
                return false;
            }

        }
        
    }
}
