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
            } while (operation != "+" && operation != "-" && operation != "*" && operation != "/");

            string numberOfValuesInput;
            do
            {
                Console.WriteLine("How many numbers would you like to {0} together?", operation);
                numberOfValuesInput = Console.ReadLine();
            } while (!(int.TryParse(numberOfValuesInput,out int intInput)&& intInput > 1));

            double[] UserValues = new double[int.Parse(numberOfValuesInput)];
            for (int iterationsComplete = 0; iterationsComplete < int.Parse(numberOfValuesInput); iterationsComplete++)
            {
                string userValue;
                do
                {
                    Console.WriteLine("{0}. Please enter a number: ",iterationsComplete+1);
                    userValue=Console.ReadLine();
                } while (!(double.TryParse(userValue, out _)));
                UserValues[iterationsComplete] = double.Parse(userValue);
            }
            double outputDouble = 0;
            switch (operation)
            {
                case "+":
                    foreach(double value in UserValues) {
                        outputDouble += value;
                    }
                    break;
                case "-":
                    foreach (double value in UserValues)
                    {
                        outputDouble -= value;
                    }
                    break;
                case "*":
                    foreach (double value in UserValues)
                    {
                        outputDouble *= value;
                    }
                    break;
                case "/":
                    foreach (double value in UserValues)
                    {
                        outputDouble /= value;
                    }
                    break;
            }
            Console.WriteLine("The answer is "+outputDouble);

        }
    }
}
