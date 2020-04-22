using System;
using System.Collections.Generic;

namespace AP.Properties.Lab2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Xin chao nhan");
            //Product p1= new Product(1,"phone",56,1,"http://somethingJustLikeThis.jpg","red");
            //Console.WriteLine(p1.GetInformation());
            //p1.Status();
            //p1.GalleryAdd();
            //p1.showGallery();
            var list = CreateListFashion();
            Console.WriteLine("danh sach san pham");
            Print(list);
            NewCheck(list,"Red",1);



        }

        static List<Fashion> CreateListFashion()
        {
            Console.WriteLine("ban vua tao mot danh sach cac san pham");
            var list=new List<Fashion>
            {
                new Fashion(1,"Diamond",23,1,"https://expensive-engagement-rings.jpg","pretty","Red",4)
                , new Fashion(2,"Gold",24,4,"http://somethingjustlikethis.jpg","gorgeous","Red",1)
            };
            return list;
        }

        static void Print(List<Fashion> list)
        {
            foreach (var p in list)
            {
                Console.WriteLine("Id : "+p.Id+
                                  "\nName: "+p.Name+
                                  "\nQuantity: "+p.Qty+
                                  "\nImange: "+p.Image);
            }
            
        }
        static void NewCheck(List<Fashion> list,string color, int size)
        {
            foreach (var i in list)
            {
                if (i.Check(color,size))
                {
                    Console.WriteLine("The product on stock");
                    break;
                }
            }
            
        }
    }
}