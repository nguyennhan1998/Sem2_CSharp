using System;

namespace AP.Properties.Assignment7_manageStudent
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ListStudent ls=new ListStudent();
        }

        public static void ChooseAction()
        {
            Console.WriteLine("Starting....");
            Console.WriteLine("Enter 1 to add student");
            Console.WriteLine("Enter 2 to edit student");
            Console.WriteLine("Enter 3 to delete student");
            Console.WriteLine("Enter 4 to sort student by gpa");
            Console.WriteLine("Enter 5 to sort student by name");
            Console.WriteLine("Enter 6 to show student");
            Console.WriteLine("Enter 7 to exit");
        }

        public static void AddSt()
        {
            Console.WriteLine("id: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
        }
    }
}