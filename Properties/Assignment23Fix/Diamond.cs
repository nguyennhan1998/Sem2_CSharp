﻿using System.Collections.Generic;

namespace AP.Properties.Assignment23Fix
{
    public class Diamond:Product
    {
        private uint cara;

        public Diamond(int id, string name, double price, uint qty, string image, string desc, List<string> gallery, uint cara) : base(id, name, price, qty, image, desc, gallery)
        {
            this.cara = cara;
        }

        public uint Cara
        {
            get { return cara + 10; }
            set
            {
                if (value > 5) cara = value;
                else cara = 5;
            }
        }

        public bool IsReal()
        {
            if (cara > 5) return true;
            return false;
        }
    }
}