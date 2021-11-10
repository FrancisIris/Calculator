using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation;

            do
            {
                Console.WriteLine("+, -, * or / ?");
                operation = Console.ReadLine();
            } while (!ValidOperatorCheck(operation));

            Console.WriteLine("How many numbers would you like to {0} together?", operation);
            int numberOfValuesInput = GetUserValue();

            int[] UserValues = new int[numberOfValuesInput];
            for (int iterationsComplete = 0; iterationsComplete < numberOfValuesInput; iterationsComplete++)
            {
                Console.WriteLine("Value {0}:",iterationsComplete+1);
                UserValues[iterationsComplete] = GetUserValue();
            }

            double outputInt = 0;
            switch (operation)
            {
                case "+":
                    foreach(int value in UserValues) {
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
            Console.WriteLine("The answer is "+outputInt);

            

        }
        static bool ValidOperatorCheck(string userInput)
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
    }
}
