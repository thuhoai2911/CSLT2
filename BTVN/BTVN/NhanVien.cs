using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTVN
{
    class NhanVien
    {
        protected string HoTen;
        protected string DiaChi;
        protected DateTime NgaySinh;
        protected double luong;

        public virtual void nhap()
        {
            Console.Write("Nhap vao ho ten NV: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap vao dia chi NV: ");
            DiaChi = Console.ReadLine();
            Console.Write("Nhap vao ngay sinh NV (yyyy/mm/dd): ");
            NgaySinh = Convert.ToDateTime(Console.ReadLine());
        }

        public virtual void xuat()
        {
            Console.WriteLine("Ho ten: {0}\t Dia chi: {1}\t Ngay sinh: {2}\nLuong: {3}", HoTen, DiaChi, NgaySinh, LuongNV());
        }

        public virtual double LuongNV()
        {
            return luong;
        }
    }
}
