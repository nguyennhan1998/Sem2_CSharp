using System;

namespace AP.Properties.AboutCSharp
{
    public class TestProduct
    {
        
        public static void Main(string[] args)
        {
            Product p1= new Product(1,"phone",56,1,"http://somethingJustLikeThis.jpg","red");
            Console.WriteLine(p1.GetInformation());
            p1.Status();
            p1.GalleryAdd();
            p1.GalleryAdd();
            p1.GalleryAdd();
            p1.showGallery();



        }
    }
}