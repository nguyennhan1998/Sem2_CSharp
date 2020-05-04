using System;

namespace AP.Properties.Assignment5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PhoneBook p1= new PhoneBook();
            p1.InsertPhone("nhan", "0393910646");
            p1.InsertPhone("linh","8379757544");
            p1.InsertPhone("vanh","093847874");
            p1.InsertPhone("huyen","094784784");
            p1.RemovePhone("huyen");
            p1.UpdatePhone("linh","0987655");
            PhoneNumber ps= p1.searchPhone("vanh");
            Console.WriteLine("name: "+ps.name +" is exist in the list");
            
        }
    }
}