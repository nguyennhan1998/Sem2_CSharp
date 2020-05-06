using System;
using System.Threading;

namespace AP.Properties.Lab8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Thread t1=new Thread(ThreadRun);
            t1.Start();
            
        }

        public static void ThreadRun()
        {
            for(int i=9;i>=0;i--){
                for(int j=59;j>=0;j--){
                    if(j<10){
                       Console.WriteLine("0"+i+":"+"0"+j);
                    }
                    else
                    {
                        Console.WriteLine("0"+i+":"+j);
                    }

                    if (i == 0 && j == 0)
                    {
                        Console.WriteLine("Boom!!!");
                    }
                    try{
                        Thread.Sleep(1000);
                    }catch (Exception e){
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }
        
    }
   
}