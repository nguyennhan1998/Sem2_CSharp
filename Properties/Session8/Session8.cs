using System;
using System.Threading;

namespace AP.Properties.Session8
{
    public class Session8
    {
        private int number=0;
        public static void Main(string[] args)
        {
            Thread t1= new Thread(ThreadRun);
            t1.Start("Xin chào");//Chạy luồng mới.
            Thread t2=new Thread(new Session8().Run2);//Chỉ cần truyển ô nhớ của hàm ấy vaò
            t2.Start();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Main i = "+i);
                Thread.Sleep(100);
            }
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
    }
}