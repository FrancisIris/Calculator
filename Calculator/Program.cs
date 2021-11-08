using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //should in future declare vars as i need them not at the start
            string n1;
            string n2;
            float output=0;
            string operation;

            Console.WriteLine("Please enter a number");
            n1 = Console.ReadLine();
            Console.WriteLine("add, minus, times, divide?");
            operation =Console.ReadLine();
            Console.WriteLine("Please enter a number you would like to "+operation+" (by)");
            n2 = Console.ReadLine();
            switch (operation)
            {
                case "add":
                    output = Int32.Parse(n1) + Int32.Parse(n2);
                    break;
                case "minus":
                    output = Int32.Parse(n1) - Int32.Parse(n2);
                    break;
                case "times":
                    output = Int32.Parse(n1) * Int32.Parse(n2);
                    break;
                case "divide":
                    output = Int32.Parse(n1) / Int32.Parse(n2);
                    break;
            }
            Console.WriteLine(n1 + " " + operation + " " + n2 + " = "+ string.Format("{0:N2}",output));
        }
    }
}
