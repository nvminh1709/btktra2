using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btktra2
{
    internal class thuvien
    {
        private List<sach> ds;

        public thuvien()
        {
            ds = new List<sach>();
        }
        public void ThemSach(sach s)
        {
            ds.Add(s);
        }
        public void XoaSach(string maSach)
        {
            sach sachCanXoa = ds.Find(sach => sach.MaSach == maSach);
            if (sachCanXoa != null)
            {
                ds.Remove(sachCanXoa);

                Console.WriteLine($"Sach co ma  {maSach} da bi xoa");
            }
            else
            {
                Console.WriteLine($"khong tim thay ma  {maSach} trong thu vien.");
            }

        }
        public void HienThiDanhSachSach()
        {
            Console.WriteLine("Danh sach sach trong thu vien:");
            foreach (sach sach in ds)
            {
                sach.hienthi();

            }
        }
    }
}
