using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class NumbersCalc
    {
        private FileHandler fileHandler;
        public NumbersCalc(FileHandler fileHandler)
        {
            this.fileHandler = fileHandler;
        }

        public void DoCalc()
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

            double outputValue = 0;
            switch (operation)
            {
                case "+":
                    outputValue = UserValues.Sum();
                    break;
                case "-":
                    outputValue = UserValues.Skip(1).Aggregate(UserValues[0],(sum, val) => sum - val);
                    break;
                case "*":
                    outputValue = UserValues.Aggregate(1,(sum, val) => sum * val);
                    break;
                case "/":
                    outputValue = UserValues.Skip(1).Aggregate(UserValues[0], (sum, val) => sum / val);
                    break;
                    //int is probably not the best choice for the calculator as it leads the division operator to regularly output 0
            }
            string answer = string.Join(operation, UserValues) + "=" + outputValue;
            Console.WriteLine(answer);
            fileHandler.AppendToFile(answer);
            Console.WriteLine("Enter to continue");
            Console.ReadLine();
        }

        private static bool GetOperator(string userInput)
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

        public static int GetUserValue()
        {
            Console.WriteLine("Enter your value:");
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out _))
            {
                return int.Parse(userInput);
            }
            else
            {
                Console.WriteLine("{0} was not a valid input", userInput);
                return GetUserValue();
            }
        }
    }
}
