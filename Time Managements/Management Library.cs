using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Time_Management_Application;

namespace Time_Managements
{
    public class Management_Library
    {

        public string Code { get; set; }
        public string Name { get; set; }
        public double NumberOfCredits { get; set; }
        public double ClassHourPerWeek { get; set; }
        public int NumberOfWeeks { get; set; }
        public DateTime StartDate { get; set; }
        public double SelfStudying { get; set; }

        public double SelfStudyHoursPerWeek(double SelfStudying ,string Code, String Name, double NumberOfCredits, double NumberOfWeeks, DateTime StartDate, double ClassHourPerWeek)
        {

            SelfStudying = ((NumberOfCredits * 10) / NumberOfWeeks) - ClassHourPerWeek;

            return SelfStudying;
        }
    }
}


















