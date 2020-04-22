namespace AP.Properties.AboutCSharp
{
    public class Student
    {
        public string name;
        public int age;

        public void ShowInfo()
        {
            //ke khai thong tin
        }

        internal void ShowName()
        {
                
        }
        //public private protected internal
        // . dll dynamic linked library
        //vi du có 10 du an thì dư an nay có thể sử dựng dự án kia
        //java đóng file jar thì ngoài và trong không thể sử dụng
        //.dll bất kỳ dự án nào muốn sử dụng thì đặt chế dộ public
        //public nó ở phạm vi toàn máy tính 
        //internal ở trong phạm vi cua internal nôi bộ
        //public là tất cả mọi nơi--> all solution
        //private
        public bool YesOrNo(int varName)
        {
            return true;
        }
    }
}