using System;
using System.Collections.Generic;

namespace AP.Properties.Assignment23Fix
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Product p1 = new Product(1, "san pham 1", 3000, 2, "anh1", "mo ta1", new List<string>());
            Fashion f1= new Fashion(2,"quan ao", 1500, 3, "fashion1.jpg","mo ta fashion 1",new List<string>(),"red ",2 );
            Diamond d1=new Diamond(1, "diamond 1",123,3,"diamond ring.jpg","diamond real",new List<string>(),3 );
            Cart c1=new Cart(1,"nguyen van a",0,new List<Product>(),"HaNoi","VN" );
            c1.AddProduct(p1);
            c1.AddProduct(f1);
            c1.AddProduct(d1);
            Console.WriteLine("Tong so tien phai thanh toan la: "+c1.FinalTotal());

        }
    }
}