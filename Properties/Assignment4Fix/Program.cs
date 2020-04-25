using System;
using System.Collections.Generic;

namespace AP.Properties.Assignment4Fix
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<KhachHangVietNam> listVN= new List<KhachHangVietNam>();
            listVN.Add(new KhachHangVietNam(1,"Nguyen van an","01/2019",155,"sinh hoat"));
            List<KhachHangNuocNgoai> listNN=new List<KhachHangNuocNgoai>();
           listNN.Add( new KhachHangNuocNgoai(2,"alex","1/2019",78,"US"));
           listNN.Add(new KhachHangNuocNgoai(2,"alex","1/2019",78,"US"));
           int totalVN = 0;
           foreach (KhachHangVietNam x in listVN)
           {
               totalVN += x.ThanhTien();
           }

           int totalNN = 0;
           foreach (KhachHangNuocNgoai x in listNN)
           {
               totalNN += x.ThanhTien();
           }
           Console.WriteLine("VN: "+totalVN);
           Console.WriteLine("NN: "+totalNN);
           Console.WriteLine("Trung binh: ");
           Console.WriteLine("VN: "+(float)totalVN/listVN.Count);
           Console.WriteLine("NN: "+(float)totalNN/listNN.Count);
           Console.WriteLine("hoa don thang 1/2019");

        }
    }
}