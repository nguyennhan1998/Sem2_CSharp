using System;
using System.CodeDom;

namespace AP.Properties.Assignment7_manageStudent
{
    public class Program
    {
        private static ListStudent ls = new ListStudent();

        public static void Main(string[] args)
        {
            Boolean quit = false;
            ChooseAction();
            while(!quit)
            {
                Console.WriteLine("Enter action: ");
                int action = Convert.ToInt32(Console.ReadLine());
                switch (action)
                {
                 case 1: AddSt();
                     break;
                 case 2: UpdateSt();
                     break;
                 case 3: DeleteSt();
                     break;
                 case 4: SortLsByGpa();
                     break;
                 case 5: SortLsByName();
                     break;
                 case 6: ls.ShowStudent();
                     break;
                 case 7: ChooseAction();
                     break;
                 case 8: Console.WriteLine("\nShutting down....");
                     quit = true;
                     break;
                }

            }
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
            Console.WriteLine("Enter 7 to show action.");
            Console.WriteLine("Enter 8 to exit");
        }

        public static void AddSt()
        {
            Console.WriteLine("id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name: ");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Address: ");
            string address = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Gpa: ");
            int gpa = Convert.ToInt32(Console.ReadLine());
            Student st1 = new Student(id, name, age, address, gpa);
            ls.AddStudent(st1);
        }

        public static void UpdateSt()
        {
            Console.WriteLine("Enter an Id of student that  you want to edit:");
            int id = Convert.ToInt32(Console.ReadLine());
            ls.EditStudent(id);
        }

        public static void DeleteSt()
        {
            Console.WriteLine("Enter id of student that you want to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());
            ls.DeleteStudent(id);
        }

        public static void SortLsByGpa()
        {
            ls.SortByGpa();
        }

        public static void SortLsByName()
        {
            ls.SortByName();
        }
    }
}