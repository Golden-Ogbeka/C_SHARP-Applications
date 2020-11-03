using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day__month_and_year
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the day in integers: ");
            int day=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the month in integers: ");
            int month1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the year in integers: ");
            int year1 = Convert.ToInt32(Console.ReadLine());
            string month;
            int daysinthemonth;
            

            int year;
            year= year1%4;
            if (year == 0) {
              Console.WriteLine("{0} is a leap year", year1);
            }
            else{
            Console.WriteLine("{0} is not a leap year", year1);
            }
            if (month1 == 1)
            {
                month = "January";
                daysinthemonth = 31;
            }
            else if (month1 == 2)
            {
                month = "February";
                if (year == 0)
                { daysinthemonth = 29; }
                else { daysinthemonth = 28; }
            }
            else if (month1 == 3) { month = "March"; daysinthemonth = 31; }
            else if (month1 == 4) { month = "April"; daysinthemonth = 30; }
            else if (month1 == 5) { month = "May"; daysinthemonth = 31; }
            else if (month1 == 6) { month = "June"; daysinthemonth = 30; }
            else if (month1 == 7) { month = "July"; daysinthemonth = 31; }
            else if (month1 == 8) { month = "August"; daysinthemonth = 31; }
            else if (month1 == 9) { month = "September"; daysinthemonth = 30; }
            else if (month1 == 10) { month = "October"; daysinthemonth = 31; }
            else if (month1 == 11) { month = "November"; daysinthemonth = 30; }
            else { month = "December"; daysinthemonth = 31; }
           
            Console.WriteLine("The date is {0} {1}, {2}, {3} has {4} days, and {5} {6} ",month,day,year1,month,daysinthemonth,year1,year);
            Console.ReadKey();
        }
        
    }
}
