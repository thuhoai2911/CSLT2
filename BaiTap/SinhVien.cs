using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap
{
    class SinhVien
    {
        private string msv;
        private string hoTen;
        private int namSinh;
        private double diemLT, diemCSDL, diemTB;

        public void nhap()
        {
            Console.Write("Nhap vao ma SV: ");
            msv = Console.ReadLine();
            Console.Write("Nhap vao ho ten SV: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap vao nam sinh cua SV: ");
            namSinh = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao diem lap trinh cua SV: ");
            diemLT = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap vao diem CSDL cua SV: ");
            diemCSDL = Convert.ToDouble(Console.ReadLine());
        }
        
        public void xuat()
        {
            Console.WriteLine("MSV: " + msv + "\nHo Ten: " + hoTen + "\nNam sinh: " + namSinh);
            Console.WriteLine("Diem LT: " + diemLT + "\tDiem CSDL: " + diemCSDL + "\tDiem TB: " + DiemTB());
        }

        public double DiemTB()
        {
            diemTB = (diemLT + diemCSDL) / 2;
            return diemTB;
        }

        public SinhVien()
        {
            msv = "";
            hoTen = "";
            namSinh = 1990;
            diemLT = diemCSDL = diemTB = 0;
        }

        public SinhVien(string msv, string hoTen, int namSinh, double diemLT, double diemCSDL)
        {
            this.msv = msv;
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.diemLT = diemLT;
            this.diemCSDL = diemCSDL;
        }
         
        public string MaSV
        {
            get { return msv; }
            set { msv = value; }
        }

    }
}
