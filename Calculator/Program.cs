using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runningCheck = true;
            while (runningCheck)
            {
                runningCheck = MainMenu();
            }
            return;
        }

        static void NumberCalculator()
        {
            string operation;
            Console.Clear();
            do
            {
                Console.WriteLine("+, -, * or / ?");
                operation = Console.ReadLine();
            } while (!GetOperator(operation));

            Console.WriteLine("How many numbers would you like to {0} together?", operation);
            int numberOfValuesInput = GetUserValue();

            int[] UserValues = new int[numberOfValuesInput];
            for (int iterationsComplete = 0; iterationsComplete < numberOfValuesInput; iterationsComplete++)
            {
                Console.WriteLine("Value {0}:", iterationsComplete + 1);
                UserValues[iterationsComplete] = GetUserValue();
            }

            double outputInt = 0;
            switch (operation)
            {
                case "+":
                    foreach (int value in UserValues)
                    {
                        outputInt += value;
                    }
                    break;
                case "-":
                    foreach (int value in UserValues)
                    {
                        outputInt -= value;
                    }
                    break;
                case "*":
                    foreach (int value in UserValues)
                    {
                        outputInt *= value;
                    }
                    break;
                case "/":
                    foreach (int value in UserValues)
                    {
                        outputInt /= value;
                    }
                    break;
            }
            Console.WriteLine("The answer is " + outputInt);
            Console.WriteLine("Enter to continue");
            Console.ReadLine();
        }

        static void DateCalculator()
        {
            Console.Clear();
            DateTime userDate = GetDate();
            Console.WriteLine("How many days would you like to add to this date?:");
            int daysAdded = GetUserValue();
            Console.WriteLine("{0} with a {1} day difference ends up as {2}.",userDate.ToShortDateString(), daysAdded, userDate.AddDays(daysAdded).ToShortDateString());
            Console.WriteLine("Enter to continue");
            Console.ReadLine();
        }

        static bool GetOperator(string userInput)
            {
                switch (userInput)
                {
                    case "+":
                        return true;
                    case "-":
                        return true;
                    case "*":
                        return true;
                    case "/":
                        return true;
                    default:
                        return false;
                }
            }

        static int GetUserValue()
            {
                Console.WriteLine("Enter your value:");
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out _))
                {
                    return int.Parse(userInput);
                }
                else
                {
                    Console.WriteLine("{0} was not a valid input",userInput);
                    return GetUserValue();
                }
            }

        static DateTime GetDate()
        {
            Console.WriteLine("Enter the date (dd/mm/yyyy)");
            string userDateInput = Console.ReadLine();
            if (DateTime.TryParse(userDateInput,out _))
            {
                return DateTime.Parse(userDateInput);
            }
            else
            {
                Console.WriteLine("{0} was not a valid date format", userDateInput);
                return GetDate();
            }
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
                    NumberCalculator();
                    break;
                case "2":
                    DateCalculator();
                    break;
                case "3":
                    return false;
            }
            return true;
        }
    }
}
