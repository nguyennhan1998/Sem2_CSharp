namespace AP.Properties.Assignment4Fix
{
    public class KhachHangVietNam:KhachHang
    {
        private string doiTuong;

        public KhachHangVietNam(int id, string name, string billDate, int number, string doiTuong) : base(id, name, billDate, number)
        {
            this.doiTuong = doiTuong;
        }

        public string DoiTuong
        {
            get => doiTuong;
            set => doiTuong = value;
        }
    }
}