

using System;

namespace AP.Properties.Lab6
{
    public delegate int CalculatorMenu(int a, int b);
    public class Program
    {
        public static void Main(string[] args)
        {
            int c;
            do
            {
                Console.WriteLine("chon mot trong cac yeu cau: ");
                Console.WriteLine("1: add\n2: Subtract\n3: Division\n4:Multi ");
                c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhap vao hai so can tinh:");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                CalculatorM cm = Calculator.GetFunction(c);
                int m=cm(a, b);
                Console.WriteLine("result: "+m);
            } while (c != 0);
        }
        
    }
}