using System;

namespace AP.Properties.Assignment4Fix
{
    public class KhachHang
    {
        protected int id;
        protected string name;
        protected string billDate;
        protected int number;

        public KhachHang(int id, string name, string billDate, int number)
        {
            this.id = id;
            this.name = name;
            this.billDate = billDate;
            this.number = number;
        }

        public KhachHang()
        {
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string BillDate
        {
            get => billDate;
            set => billDate = value;
        }

        public int Number
        {
            get => number;
            set => number = value;
        }

        public int ThanhTien()
        {
            if (Number <= 0)
            {
                return Number * 1000;
            }else if (Number <= 100)
            {
                return 50 * 1000 + (number - 50) * 1200;
            }else if (Number <= 200)
            {
                return 50 * 1000;
            }

            return 2000;
        }

        public void ShowBill()
        {
            Console.WriteLine("ID: "+id);
            Console.WriteLine("Name: "+name);
            Console.WriteLine("ID: "+id);
            Console.WriteLine("ID: "+id);
            Console.WriteLine("ID: "+id);
        }
    }
}