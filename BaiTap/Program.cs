using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiTap
{
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv1 = new SinhVien();
            sv1.nhap();
            Console.WriteLine("Thong tin sinh vien vua nhap: ");
            sv1.xuat();

            DanhSachSV ds1 = new DanhSachSV();
            ds1.nhapDS();
            Console.WriteLine("Thong tin DS sinh vien vua nhap: ");
            ds1.xuatDS();

            ds1.LietKe();

            ds1.sapxep();
            ds1.xuatDS();

            Console.ReadLine();
        }
    }
}
