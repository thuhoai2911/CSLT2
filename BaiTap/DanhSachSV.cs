using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap
{
    class DanhSachSV
    {
        int n;
        SinhVien[] DanhSach = new SinhVien[50];
        
        public void nhapDS()
        {
            Console.Write("Nhap vao so luong SV: ");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                DanhSach[i] = new SinhVien();
                Console.WriteLine("====Sinh Vien [{0}]: ", i);
                DanhSach[i].nhap();
            }
        }
        
        public void xuatDS()
        {
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("====Thong tin SV [{0}]", i);
                DanhSach[i].xuat();
            }
        }

        public void LietKe ()
        {
            Console.WriteLine("\nDS sinh vien cos diemTB >8:");
            for (int i=0;i<n;i++)
            {
                if (DanhSach[i].DiemTB() > 8)
                    DanhSach[i].xuat();
            }
        }
        public void sapxep()
        {
            Console.WriteLine("\nDS sinh vien sau khi sap xep: ");
            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                {
                    if (string.Compare(DanhSach[i].MaSV, DanhSach[j].MaSV,true)>0)
                    {
                        SinhVien tg = new SinhVien();
                        tg = DanhSach[i];
                        DanhSach[i] = DanhSach[j];
                        DanhSach[j] = tg;
                    }
                }
        }
    }
}
