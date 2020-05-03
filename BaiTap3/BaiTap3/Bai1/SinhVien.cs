using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiTap3.Bai1
{
    class SinhVien
    {
        protected string hoTen;
        protected DateTime ngaySinh;
        protected double diemLT, diemCSDL, diemTKWeb;

        public void nhap()
        {
            Console.Write("Nhap ho ten SV: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap vao ngay sinh: ");
            ngaySinh = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Nhap vao diem thi mon Lap trinh: ");
            diemLT = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap vao diem thi mon CSDL: ");
            diemCSDL = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap vao diem thi mon Thiet ke Web: ");
            diemTKWeb = Convert.ToDouble(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine("Ho ten: {0}\tNgay sinh: {1}\tDiem LT: {2}\tDiem CSDL: {3}\tDiem Tk Web: {4}",
                hoTen, ngaySinh, diemLT, diemCSDL, diemTKWeb);
        }

        public double DiemTB()
        {
            return (diemLT + diemCSDL + diemTKWeb) / 3;
        }

        public int TotNghiep()
        {
            int k = 0;
            if (DiemTB() >= 8 && diemLT >= 5 && diemCSDL >= 5 && diemTKWeb >= 5) k = 1;
            else if (diemLT >= 5 && diemCSDL >= 5 && diemTKWeb >= 5) k = 2;
            return k;
        }
    }
}
