using System;
using System.Linq.Expressions;

namespace AP.Properties.Lab6Fix
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int choose;
            do
            {
                ShowMenu();
                choose = ReadNumber();
                if (choose > 0 && choose < 5)
                {
                    Console.WriteLine("Nhap so thu nhat: ");
                    int no1 = ReadNumber();
                    Console.WriteLine("nhap so thu hai: ");
                    int no2 = ReadNumber();
                    MathNumber mn = Calc.GetFunction(choose);
                    switch (choose)
                    {
                        case 1: Console.WriteLine("Tong cua hai so: "+mn(no1,no2));
                            break;
                        case 2: Console.WriteLine("Hieu cua hai so: "+mn(no1,no2));
                            break;
                        case 3: Console.WriteLine("Tich cua hai so: "+mn(no1,no2));
                            break;
                        case 4: Console.WriteLine("Thuong cua hai so: "+mn(no1,no2));
                            break;
                        
                    }

                }
                
            } while (choose != 0);
        }

        public static void ShowMenu()
        {
            Console.WriteLine("Lua chon chuc nang: ");
            Console.WriteLine("1. Cong");
            Console.WriteLine("2. Tru");
            Console.WriteLine("3. Nhan");
            Console.WriteLine("4. Chia");
        }

        public static int ReadNumber()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}