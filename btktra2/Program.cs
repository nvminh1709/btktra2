namespace btktra2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            thuvien tv = new thuvien();
            sach sach1 = new sach("MS001", "Nhung ngưoi khon kho", "Victor Hugo");
            sach sach2 = new sach("MS002", "Toan cao cap", "Nguyen Van A");
            tv.ThemSach(sach1);
            tv.ThemSach(sach2);
            tv.HienThiDanhSachSach();
            tv.XoaSach("MS001");
            tv.HienThiDanhSachSach();
        }
    }
}