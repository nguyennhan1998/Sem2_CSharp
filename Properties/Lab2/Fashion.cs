using System;
using System.Collections.Generic;

namespace AP.Properties.Lab2
{
    public class Fashion : Product
    {
        protected string color;
        protected int size;
        List<Fashion> listFashion = new List<Fashion>();

        public Fashion()
        {
            Console.WriteLine("ban vua tao ra mot danh sach ");
        }

        public Fashion(int id, string name, int price, int qty, string image, string desc, string color, int size) :
            base(id, name, price, qty, image, desc)
        {
            this.color = color;
            this.size = size;
        }
        

        public string GetColor()
        {
            return color;
        }

        public int GetSize()
        {
            return size;
        }

        public bool Check(string color, int size)
        {
           
            if (GetColor().Equals(color) && GetSize() == size)
            {
                return true;
            }

            return false;
        }
    }
}