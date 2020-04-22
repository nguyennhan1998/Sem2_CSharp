using System;

namespace AP.Properties.AboutCSharp
{
    public class Lession2
    {
         public static void Main(string[] args)
                {
                    Student s1=new Student();
                    //s1 kaf 1 doi tuong ta ra tu lop student
                    //new student() moi la doi tuong-> toa ra 1 o nho chua: name, age, function showinfor
                    s1.ShowName();
                    Social.Hello();//className.MethodName();
                    Console.WriteLine(Social.FirstWeekOfYear+10);
                }
    }
}