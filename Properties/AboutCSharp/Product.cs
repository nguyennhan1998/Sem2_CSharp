using System;
using System.Collections.Generic;

namespace AP.Properties.AboutCSharp
{
    public class Product
    {
         private int id;
        private string name;
        private float price;
        private int qty;
        private string image;
        private string desc;
        private List<string> gallery = new List<string>();

        public Product(int id, string name, float price, int qty, string image, string desc)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
        }

        public Product()
        {
            Console.WriteLine("ban vua tao ra mot doi tuong product");
        }

        public string GetInformation()
        {
            return "ID : " + id +
                   "\nName: " + name +
                   "\nPrice: " + price +
                   "\nQty: " + qty +
                   "\nimage: " + image +
                   "\ndesc: " + desc
                ;
        }

        public void Status()
        {
            if (qty > 0)
            {
                Console.WriteLine("Con hang");
            }
            else
            {
                Console.WriteLine("het hang");
            }
        }

        public void showGallery()
        
        {
            Console.WriteLine("list gallery:");
            foreach (var VARIABLE in gallery)
            
            {
             Console.WriteLine(VARIABLE);   
            }
        }
        public void GalleryAdd()
        {
            if (gallery.Count < 2)
            {
                Console.WriteLine("nhap vao mot image");
                string url;
                url = Console.ReadLine();
                gallery.Add(url);
                Console.WriteLine("Ban vua them thanh cong: " + url);
            }

            else
            {
                Console.WriteLine("nhap vao hinh anh");
                string str;
                str = Console.ReadLine();
                Console.WriteLine("qua so luong file cho phep");
                Console.WriteLine("chon file ban muon xoa\n");
                int number;
                number = Convert.ToInt32(Console.ReadLine());
                gallery.Remove(gallery[number]);
                gallery.Add(str);
            }
        }
    }
}