using System;

namespace AP.Properties.Session6
{
    //khai báo 1 delegate trả về int và có 2 tham số
    public delegate int IntegerToInteger(int a, int b);
    public class Program
    {
        public static void Main(string[] args)
        {
            //Tao 1 doi tuong delegate
            IntegerToInteger ii=new IntegerToInteger(Calculator.Add);//Tham chiếu đến ô nhơ của hàm
           // Program.Add(2, 4);
           ii += Calculator.Subtract;//nạp thêm hàm vào chuỗi thực hiện của delegate
           ii+=new Calculator().Division;
           int a=ii(5, 2);//thuc thi cac ham duoc nap vao delegate
           Console.WriteLine("a = "+a);
           // Calculator.Add(2, 5);
            //Calculator.Subtract(2,5);
            // luon can chay 2 dong song song voi moi cap do
            //Calculator.Add(7, 3);
           // Calculator.Subtract(7,3);
           TaxMoney tm = TaxCalc.GetTax("VN");//tm la delegate
           float tax = tm(100000000);
           Console.WriteLine("thue phai nop: "+tax);
           TaxMoney tm2= delegate(float salary) { return salary * 40 / 100; };
           float frTax = tm2(1000);
           Console.WriteLine("Thue tai phap"+frTax);

        }
    }
}