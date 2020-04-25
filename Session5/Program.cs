using System;

namespace AP.Session5
{
    public class Program
    {
        public static int ProgramCode;
    }
//tạo đối tượng program của namespace AP.session5 không biết của cái nào

    namespace MyNameSpace
    {
        public class MyClass
        {
            public void ShowInfo()
            {
                try
                {
                    int x = 10;
                    int y = 0;
                    Console.WriteLine(x / y);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("successful");
            }
            
        }
    }
}

namespace AP.Session5.Demo
{
    public class Program
    {
        
    }
}