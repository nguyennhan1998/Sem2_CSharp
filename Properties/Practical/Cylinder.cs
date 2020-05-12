using System;

namespace AP.Properties.Practical
{
    public class Cylinder
    {
        private double baseArea;
        private double lareralArca;
        private double totalArea;
        private double volume;

        public void Caculate(double radius, double height)
        {
            baseArea =  radius * radius * Math.PI;
            lareralArca = 2 * Math.PI * radius * height;
            totalArea = 2 * Math.PI * radius * (height + radius);
            volume = Math.PI * radius * radius * height;
        }

        public void Result()
        {
            Console.WriteLine("base: "+this.baseArea+
                              "\nlateral: "+this.lareralArca+
                              "\nTotal: "+this.totalArea+
                              "\nVolume: "+this.volume);
        }
    }
}