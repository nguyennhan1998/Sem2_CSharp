using System;

namespace AP.Properties.Assignment4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Bill b1= new Bill(1,"john",DateTime.Now, "america",200,0,0);
            b1.PrintBill();
        }
        
    }
}