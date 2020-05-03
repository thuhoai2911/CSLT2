using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BaiTap3.Bai1;
using BaiTap3.Bai2;

namespace BaiTap3
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhSachSV ds1 = new DanhSachSV();
            ds1.nhapDS();
            ds1.Dem();
            Console.ReadKey();

            ThongTinThue tt1 = new ThongTinThue();
            tt1.nhap();
            tt1.xuat();
            Console.ReadKey();
        }
    }
}
