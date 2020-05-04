using System;
using System.Threading;

namespace AP.Properties.Lab6
{
    public delegate int CalculatorM(int a, int b);
    public class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Division(int a, int b)
        {
            if (b == 0) return 0;
            return a / b;
        }

        public static int Multi(int a, int b)
        {
            return a * b;
        }

        public static CalculatorM GetFunction(int a)
        {
            if (a == 1)
            {
                return Add;
            }else if (a == 2)
            {
                return Subtract;
            }else if (a == 3)
            {
                return Division;
            }
            else if(a==4)
            {
                return Multi;
            }
            else
            {
                return null;
            }
        }
    }
}