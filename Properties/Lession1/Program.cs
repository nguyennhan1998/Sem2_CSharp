using System;
using System.Collections;
using System.Collections.Generic;//import

namespace AP.Properties.Lession1//package
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //nhap tu ban phim chi cho phep nhap chuoi
            /*Console.WriteLine("hello world");*/
            //khai bao mot bien
            //cau truc cau lenh de nhap vao mot chuoi
            /*string str;
            Console.WriteLine("Nhap vao mot chuoi \n");
            str = Console.ReadLine();
            Console.WriteLine(str);*/
            //cau truc cau lenh de nhap vao mot so
            /* int no;
             Console.WriteLine("Nhap vao mot so nguyen \n");
             no = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("so nguyen ban vua nhap la " + no);*/
            dynamic x;//kieu du lieu dong
            x = 20;//x la mot so nguyen
            //Console.WriteLine(x+15);
            
                x = "xin chao";
           // Console.WriteLine(x+15);
        }

        private static void TotalNumber()
        {
            //c1
            var numberOne = 2;
            int numberTwo;
            if (numberOne > 2)
            {
                numberTwo = 2;
            }
            else
            {
                numberTwo = 1;
            }

            //c2: 
            numberTwo = numberOne > 2 ? 2 : 1;
            //bieu thuc boolean
            var x = numberTwo > numberOne;
            //cau truc if else
            if (numberOne > numberTwo)
            {
            }

            //cau truc nhieu if else long nhau
            if (x)
            {
            }
            else if (!x)

            {
            }
            else
            {
            }

            //cau truc switch
            switch (x)
            {
                case true: break;
                case false: break;
            }

            //khai bao mang co ba cach 
            //theo kieu thong thuong 
            int[] ary = {1, 2, 3};
            //vong lap duyet mang for
            for (int i = 0; i < 3; i++) Console.WriteLine(i);
            //vong lap duyet mang for-each
            foreach (var i in ary)
            {
                Console.WriteLine(i);
            }

            int[] arr1 = {1, 2, 3};
            var arr2 = new double[5];
            arr2[1] = 2;
            arr2[2] = 3;
            //cach 2 la khai bao mang dang arraylist la mot mang nhieu kieu du lieu khac nhau
            var arr3= new ArrayList();
            arr3.Add(3);
            arr3.Add(5);
            arr3.Add(4);
            //cach 3 la khai bao mang kieu list
            var arr4= new List<int>();
            arr4.Add(2);
            arr4[2] = 9;
            //duyet mang
            for(var i=0;i<arr3.Count;i++) Console.WriteLine(i);
            foreach (var i in arr3) Console.WriteLine(i);
            {
                
            }
        }
    }
}