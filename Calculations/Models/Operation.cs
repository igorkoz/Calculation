using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculations.Models
{
    public class Operation
    {
        public static string ExecuteOperation(string operationName, double num1, double num2)
        {
            string result = String.Empty;

            switch(operationName)
            {
                case "Add":
                    result = Add(num1, num2).ToString();
                    break;
                case "Multiply":
                    result = Multiply(num1, num2).ToString();
                    break;
                case "Exp":
                    result = Exp(num1, num2).ToString();
                    break;
                case "Square":
                    result = Square(num1).ToString();
                    break;
                case "Compare":
                    result = Compare(num1, num2).ToString();
                    break;
            }

            return result;

        }

        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Exp(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }

        public static double Square(double num1)
        {
            return num1 * num1;
        }

        public static int Compare(double num1, double num2)
        {
            return num1.CompareTo(num2);
        }
    }
}
