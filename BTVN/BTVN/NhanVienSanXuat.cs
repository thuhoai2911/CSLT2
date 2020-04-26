using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTVN
{
    class NhanVienSanXuat:NhanVien
    {
        protected int soSP;

        public override void nhap()
        {
            Console.WriteLine("--Thong tin Nhan vien San xuat--");
            base.nhap();
            Console.Write("Nhap vao so san pham: ");
            soSP = Convert.ToInt32(Console.ReadLine());
        }

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("So san pham: {0}", soSP);
        }

        public override double LuongNV()
        {
            luong = soSP * 30000;
            return base.LuongNV();
        }
    }
}
