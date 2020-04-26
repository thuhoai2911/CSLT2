using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTVN
{
    class NhanVienCongNhat:NhanVien
    {
        protected int soNgayCong;

        public override void nhap()
        {
            Console.WriteLine("--Thong tin Nhan vien Cong nhat--");
            base.nhap();
            Console.Write("Nhap vao so ngay cong: ");
            soNgayCong = Convert.ToInt32(Console.ReadLine());
        }

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("So ngay cong: {0}", soNgayCong);
        }

        public override double LuongNV()
        {
            luong = soNgayCong * 90000;
            return base.LuongNV();
        }
    }
}
