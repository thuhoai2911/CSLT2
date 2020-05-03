using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiTap3.Bai2
{
    class ThongTinThue
    {
        protected string hoTenNguoiThue;
        protected double sogio;
        protected int loaiXe;
        protected Xe kieuXe;

        public void nhap()
        {
            Console.Write("Nhap ho ten nguoi thue xe: ");
            hoTenNguoiThue = Console.ReadLine();
            Console.Write("Nhap so gio thue xe: ");
            sogio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap loai xe thue: \n1. Xe Du Lich\n2. Xe Tai");
            loaiXe = Convert.ToInt32(Console.ReadLine());

            switch(loaiXe)
            {
                case 1:
                    {
                        kieuXe = new XeDuLich();
                        break;
                    }
                case 2:
                    {
                        kieuXe = new XeTai();
                        break;
                    }
            }
        }

        public void xuat()
        {
            Console.WriteLine("Ho ten nguoi thue: {0}\nSo gio thue: {1}\nTong tien: {2}", hoTenNguoiThue, sogio, kieuXe.TongTien(sogio));

        }
    }
}
