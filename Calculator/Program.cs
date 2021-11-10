using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome.");
            bool runningCheck = true;
            while (runningCheck)
            {
                runningCheck = MainMenu();
            }
            return;
        }


        static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Mode options:");
            Console.WriteLine("1) Numbers");
            Console.WriteLine("2) Dates");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();
            switch (result)
            {
                case "1":
                    NumbersCalc.NumberCalculator();
                    break;
                case "2":
                    DatesCalc.DateCalculator();
                    break;
                case "3":
                    return false;
            }
            return true;
        }
    }
}
