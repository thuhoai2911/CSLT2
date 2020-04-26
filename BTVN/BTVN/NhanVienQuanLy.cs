using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTVN
{
    class NhanVienQuanLy :NhanVien
    {
        protected double heSoLuong;
        protected double luongCoBan;

        public override void nhap()
        {
            Console.WriteLine("--Thong tin Nhan vien Quan ly--");
            base.nhap();
            Console.Write("Nhap vao he so luong: ");
            heSoLuong = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap vao luong co ban: ");
            luongCoBan = Convert.ToDouble(Console.ReadLine());
        }

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("He so luong: {0}\nLuong co ban: {1}", heSoLuong,luongCoBan);
        }

        public override double LuongNV()
        {
            luong = heSoLuong * luongCoBan;
            return base.LuongNV();
        }
    }
}
