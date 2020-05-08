using System;

namespace AP.Properties.Session8
{
    public class NumberCounter
    {
        public int x = 0;
        public int y = 0;

        public void Show()
        {
            Console.WriteLine("X : "+x);
            Console.WriteLine("y : "+y);
        }

        public void Change()
        {
            x++;
            y++;
        }
    }
}