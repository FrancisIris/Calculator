using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Calculator
{
    public class FileHandler
    {
        private const string location = @"C:\Users\Francis.Jordan\Training/Calculations.txt";

        public FileHandler()
        {
            if (File.Exists(location))
            {
                File.Delete(location);
            }
        }

        public void AppendToFile(string equation)
        {
            File.AppendAllText(location, equation + "\n");
        }
    }
}
