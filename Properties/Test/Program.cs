using System;
using System.Collections;

namespace AP.Properties.Test
{
    public class Program
    {
       

        public static void Main(string[] args)
        {
            ArrayList arrPersons= new ArrayList();
            arrPersons.Add(new Person("Nguyen Van a", 20));
            arrPersons.Add(new Person("Nguyen Van b", 19));
            arrPersons.Add(new Person("Nguyen Van c", 18));
            Console.WriteLine("Danh sach Person ban dau: ");
            foreach (Person item in arrPersons)
            {
                Console.WriteLine(item.ToString());
            }
            arrPersons.Sort(new SortPersons());
            Console.WriteLine();
            Console.WriteLine("Danh sach person da duoc sap xep");
            foreach (Person item in arrPersons)
            {
                Console.WriteLine(item.ToString());
            }
            
            
        }
    }
}