using System;

namespace AP.Properties.Lession3
{
    public abstract class Human
    {
        protected string name;
        protected int age;
        public abstract void AddFriend();

        public virtual void Running()
        {
            Console.WriteLine("run");
        }

        public void Eat()
        {
            Console.WriteLine("Eating ...");
        }
    }
}