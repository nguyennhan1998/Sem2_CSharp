using System;
using System.Collections.Generic;

namespace AP.Properties.Lab2
{
    public class TestForDiamond
    {
        public static void Main(string[] args)
        {
            var list = Initialized();
            CheckDiamond(list);

        }

        static List<Diamond> Initialized()
        {
            var list= new List<Diamond>
            {
                {new Diamond(1,"diamond 1",29,29,"http://diamon.jpg","white",23,43)},
                {new Diamond(2,"diamond 2",20,29,"http://diamon.jpg","white",23,43)},
                {new Diamond(3,"diamond 3",38,29,"http://diamon.jpg","white",23,43)},
                {new Diamond(4,"diamond 4",47,29,"http://diamon.jpg","white",23,43)},
                {new Diamond(5,"diamond 5",15,29,"http://diamon.jpg","white",23,43)}
            };
            return list;
        }

        static void CheckDiamond(List<Diamond> list)
        {
            foreach (var p in list)
            {
                if (p.RealOrFake())
                {
                    Console.WriteLine("It is real Diamond");
                }
                else
                {
                    Console.WriteLine("It is fake diamond");
                }
                
            }
        }
    }
}