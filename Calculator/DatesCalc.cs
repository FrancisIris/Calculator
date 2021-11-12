using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class DatesCalc: ICalc
    {
        private FileHandler fileHandler;
        public DatesCalc(FileHandler fileHandler)
        {
            this.fileHandler = fileHandler;
        }
        public void DoCalc()
        {
            Console.Clear();
            DateTime userDate = GetDate();
            Console.WriteLine("How many days would you like to add to this date?:");
            int daysAdded = NumbersCalc.GetUserValue();
            string answer = $"{userDate.ToShortDateString()} with a {daysAdded} day difference ends up as {userDate.AddDays(daysAdded).ToShortDateString()}.";
            Console.WriteLine(answer);
            fileHandler.AppendToFile(answer);
            Console.WriteLine("Enter to continue");
            Console.ReadLine();
        }

        private static DateTime GetDate()
        {
            Console.WriteLine("Enter the date (dd/mm/yyyy)");
            string userDateInput = Console.ReadLine();
            if (DateTime.TryParse(userDateInput, out _))
            {
                return DateTime.Parse(userDateInput);
            }
            else
            {
                Console.WriteLine("{0} was not a valid date format", userDateInput);
                return GetDate();
            }
        }
    }
}
