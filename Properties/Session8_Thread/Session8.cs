using System;
using System.Threading;

namespace AP.Properties.Session8
{
    public class Session8_Thread
    {
        private int number=0;
        public static void Main(string[] args)
        {
            Thread t3=new Thread(Run3);
            t3.Start(15);
           /* Thread t1= new Thread(ThreadRun);
            t1.Start("Xin chào");//Chạy luồng mới.
            Thread t2=new Thread(new Session8().Run2);//Chỉ cần truyển ô nhớ của hàm ấy vaò
            t2.Start();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Main i = "+i);
                Thread.Sleep(100);
            }*/
        }

        public static void ThreadRun(object o)//không có tham só hoặc 1 tham số object.
        {
            string msg = (string) o;//DownCasting
            for (int i = 0; i < 100; i++){
                Console.WriteLine(msg+"i: "+i);
                Thread.Sleep(100);
        }
        }
        public void Run2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(" Xtz=" +i);
                Thread.Sleep(100);
                    
            }
                
        }

        public static void Run3(object o)
        {
            int n = (int) o;
            for (int i = n-1; i < 0; i--)
            {
                for (j == 59; i >= 0; j--)
                {
                    //keyword: number fomat 01 02 in C#
                    Console.WriteLine(i.ToString("D2")+j.toString("D2"));
                    Thread.Sleep(10);
                }
            }
            Console.WriteLine("Boom!!");
        }
    }
}