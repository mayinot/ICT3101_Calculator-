using System;
using System.Globalization;
using System.IO;
using System.Runtime.Intrinsics.Arm;

namespace ICT3101_Calculator_Lab2
{
    public class Calculator
    {
        public Calculator() { }

        public double DoOperation(double num1, double num2, double num3, double num4, string op)
        {
            double result = double.NaN; // Default value
            // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    // Askthe user to enter a non-zero divisor.
                    result = Divide(num1, num2);
                    break;
                case "f":
                    // factorial of first number entered
                    result = Factorial(num1);
                    break;
                case "t":
                    result = AreaOfTriangle(num1, num2);
                    break;
                case "c":
                    result = AreaOfCircle(num1);
                    break;
                case "av":
                    result = Availability(num1, num2);
                    break;
                case "mtbf":
                    result = MeanTimeBeforeFailure(num1, num2);
                    break;
                case "fi":
                    result = FailureIntensity(num1, num2, num3);
                    break;
                case "afe":
                    result = AverageFailureExpected(num1, num2, num3);
                    break;
                case "lfi":
                    result = LogModelFailureIntensity(num1, num2, num3);
                    break;
                case "lafe":
                    result = LogModelAverageFailureExpected(num1, num2, num3);
                    break;
                case "dd":
                    result = DefectDensity(num1, num2);
                    break;
                case "iss":
                    result = NewISS(num1, num2, num3, num4);
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
        static bool isbin(string s)
        {
            foreach (var c in s)
                if (c != '0' && c != '1')
                    return false;
            return true;
        }
        public static double BinaryStringToSingle(string s)
        {
            return Convert.ToInt32(s, 2);
        }

        public double Add(double num1, double num2)
        {
            string str1 = num1.ToString();
            string str2 = num2.ToString();
            if( isbin(str1) && isbin(str2) )
            {
                string strnum = num1.ToString() + num2.ToString();
                double num = BinaryStringToSingle(strnum);
                return num;
            }
            else
            {
                return (num1 + num2);
            }
            
        }
        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }
        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }
        public double Divide(double num1, double num2)
        {
            if (num1 == 0 && num2 == 0)
            {
                return 1;
            }

            return (num1 / num2);
        }
        public double Factorial(double num1)
        {
            double result = 1;
            if (num1 < 0)
            {
                throw new ArgumentException("Negative num");
            }
            if (num1 == 0)
            {
                result = 1;
            }
            else
            {
                for (int i = 2; i <= num1; i++)
                {
                    result *= i;
                }
            }

            return result;
        }

        public double AreaOfTriangle(double num1, double num2)
        {
            if (num1 <= 0 || num2 <= 0)
            {
                throw new ArgumentException("Length and Heigth cannot be less than or equal to zero");
            }

            return ((num1 * num2) / 2.0);
        }

        public double AreaOfCircle(double num1)
        {
            if (num1 <= 0)
            {
                throw new ArgumentException("Radius cannot be less than or equal to zero");
            }
            double pi = Math.PI;

            return (pi * num1 * num1);
        }

        // UnknownFunctionA’s Unit tests:
        // [Hint a. involves the following function uses: 2 Factorials, 1 Divide, and 1 Subtract.]
        public double UnknownFunctionA(double num1, double num2)
        {
            return Divide(Factorial(num1), Factorial(Subtract(num1, num2)));
        }

        //  UnknownFunctionB’s Unit tests:
        // [Hint b. involves the following function uses: 3 Factorials, 1 Divide, 1 Multiply, and 1 Subtract.]
        public double UnknownFunctionB(double num1, double num2)
        {
            return (Divide(Factorial(num1), Multiply(Factorial(num2), Factorial(Subtract(num1, num2)))));

        }

        public double MeanTimeBeforeFailure(double num1, double num2)
        {
            return (num1 + num2);
        }

        public double Availability(double num1, double num2)
        {
            return (num1 / (num1 + num2)) ;
        }

        public double FailureIntensity(double num1, double num2, double num3)
        {
            return (num1 * (1 - (num2 / num3)));
        }

        public double AverageFailureExpected(double num1, double num2, double num3)
        {
            return (num3 * (1 - Math.Exp(-(num1 * num2) / num3)));
        }

        public double LogModelFailureIntensity(double num1, double num2, double num3)
        {
            return (num1 * Math.Exp(-num2 * num3));
        }

        public double LogModelAverageFailureExpected(double num1, double num2, double num3)
        {
            return ((1 / num2) * Math.Log((num1 * num2 * num3) + 1));
        }

        public double NewISS(double num1, double num2, double num3, double num4)
        {
            return ( num1 + num2 - (num2 * num3) - num4);
        }

        public double DefectDensity(double num1, double num2)
        {
            return (num1 / num2);
        }
    }
}
