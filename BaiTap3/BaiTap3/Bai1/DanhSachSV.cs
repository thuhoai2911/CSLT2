using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BaiTap3.Bai1;
namespace BaiTap3.Bai1
{
    class DanhSachSV
    {
        protected int n;
        SinhVien[] ds = new SinhVien[100];

        public void nhapDS()
        {
            Console.Write("Nhap vao so luong SV: ");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                ds[i] = new SinhVien();
                ds[i].nhap();
            }
        }

        
        public void Dem()
        {
            int demKL = 0;
            int demCD = 0;
            for(int i=0;i<n;i++)
            {
                if (ds[i].TotNghiep() == 1) demKL++;
                else if (ds[i].TotNghiep() == 2) demCD++;
            }
            Console.WriteLine("So luong SV duoc lam khoa luan: " + demKL);
            Console.WriteLine("So luong SV duoc lam chuyen de: " + demCD);
        }
    }
}
