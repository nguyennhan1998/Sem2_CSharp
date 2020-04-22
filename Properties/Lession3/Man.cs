using System;

namespace AP.Properties.Lession3
{
    public class Man: Human,IHuman
    {
        public override void AddFriend()
        {
            
        }

        public void ALo()
        {
            
        }

        public void SayHello()
        {
            Console.WriteLine("Hello everybody!");
        }

        public void SayHello(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}