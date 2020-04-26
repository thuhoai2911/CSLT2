using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTVN
{
    class DanhSachNhanVien:NhanVien
    {
        protected int soLuongNV;
        NhanVien[] ds = new NhanVien[50];

        public override void nhap()
        {
            Console.WriteLine("--Danh Sach Nhan Vien--");
            Console.Write("Nhap vao so luong nhan vien: ");
            soLuongNV = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<soLuongNV;i++)
            {
                Console.WriteLine("Chon loai NV: \n1. NV San xuat \n2. NV Cong nhat \n3. NV Quan Ly");
                int loaiNV = Convert.ToInt32(Console.ReadLine());
                switch (loaiNV)
                {
                    case 1:
                        {
                            ds[i] = new NhanVienSanXuat();
                            ds[i].nhap();
                        }
                        break;
                    case 2:
                        {
                            ds[i] = new NhanVienCongNhat();
                            ds[i].nhap();
                        }
                        break;
                    case 3:
                        {
                            ds[i] = new NhanVienQuanLy();
                            ds[i].nhap();
                        }
                        break;
                }

            }
        }

        public override void xuat()
        {
            for(int i=0;i<soLuongNV;i++)
            {
                ds[i].xuat(); 
            }
            
        }
    }
}
