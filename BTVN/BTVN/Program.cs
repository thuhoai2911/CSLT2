using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTVN
{
    class Program
    {
        static void Main(string[] args)
        {
            NhanVienSanXuat nv1 = new NhanVienSanXuat();
            nv1.nhap();
            nv1.xuat();
            Console.ReadKey();

            NhanVienCongNhat nv2 = new NhanVienCongNhat();
            nv2.nhap();
            nv2.xuat();
            Console.ReadKey();

            NhanVienQuanLy nv3 = new NhanVienQuanLy();
            nv3.nhap();
            nv3.xuat();
            Console.ReadKey();

            DanhSachNhanVien ds1 = new DanhSachNhanVien();
            ds1.nhap();
            ds1.xuat();
            Console.ReadKey();
        }
    }
}
