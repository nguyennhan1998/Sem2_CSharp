using System;

namespace AP.Properties.Lession3
{
    public class Woman : Human
    {
        public override void AddFriend()
        {
            
        }

        public override void Running()
        {
            Console.WriteLine("vua chay vua hat");
        }

        public new void Eat()
        {
            Console.WriteLine("Eating and Sing...");
        }
    }
}