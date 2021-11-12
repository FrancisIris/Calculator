using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            var fileHandler = new FileHandler();

            Console.WriteLine("Welcome.");
            bool runningCheck = true;
            while (runningCheck)
            {
                runningCheck = MainMenu(fileHandler);
            }
            return;
        }


        static bool MainMenu( FileHandler fileHandler)
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
                    new NumbersCalc(fileHandler).DoCalc();
                    break;
                case "2":
                    new DatesCalc(fileHandler).DoCalc();
                    break;
                case "3":
                    return false;
            }
            return true;
        }
    }
}
