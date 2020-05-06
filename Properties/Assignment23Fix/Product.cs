

using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;

namespace AP.Properties.Assignment23Fix
{
    public class Product
    {
        protected int id;
        protected string name;
        protected double price;
        protected uint qty;
        protected string image;
        protected string desc;
        protected List<string> gallery;
        public static int yearCode;
        private event ShowAlert ChangeQty;

        public Product(int id, string name, double price, uint qty, string image, string desc, List<string> gallery)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
            this.gallery = gallery;
        }
        

        public string this[int index]
        {
            get { return gallery[index]; }
            set { gallery[index] = value; }
        }

        public List<string> Gallery
        {
            get => gallery;
            //set => gallery = value;
        }

        public static int YearCode
        {
            get => yearCode;
            set => yearCode = value;
        }

        public Product()
        {
            gallery=new List<string>();
            if (ChangeQty == null)
            {
                ChangeQty += Cart.AlertMessage;
            }
        }

        public int Id
        {
            get { return id; }
            set { this.id = value; }
        }

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public double Price
        {
            get { return price; }
            set { this.price = value; }
        }

        public uint Qty
        {
            get { return qty; }
            set
            {
                if (qty != 0)
                {
                    ChangeQty("so luong san pham da duoc chinh sau");
                    qty = value;
                }
            }
        }

        public string Image
        {
            get { return image; }
            set { this.image = value; }

        }

        public string Desc
        {
            get { return desc;}
            set { this.desc = value; }
        }

        public void GetInfor()
        {
            Console.WriteLine("ID: "+this.id+" name: "+this.name+" qty: "+this.qty+" price: "+this.price+" desc: "+this.desc);
        }

        public bool CheckStock()
        {
            if (qty > 0) return true;
            return false;
        }

        public bool AddGallery(String image)
        {
            if (gallery.Count > 10)
            {
                Console.WriteLine("anh da vuot qua so luong, vui long xoa anh truoc khi them.");
                return false;
            }
            gallery.Add(image);
            return true;
        }

        public void DeleteGallery()
        {
            Console.WriteLine("danh sach anh");
            for (int i = 0; i < gallery.Count; i++)
            {
                Console.WriteLine(i + "." + gallery[i]);
            }
            Console.Error.WriteLine("chon anh de xoa: ");
            int stt = Convert.ToInt32(Console.ReadLine());
            gallery.RemoveAt(stt);
            
        }

        public bool DeleteImage(string image)
        {
            return gallery.Remove(image);
        }

        public bool DeleteAt(int number)
        {
            if (number < gallery.Count && number > 0)
            {
                gallery.RemoveAt(number);
                return true;
            }

            return false;
        }
    }
}