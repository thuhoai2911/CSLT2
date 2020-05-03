using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiTap3.Bai2
{
    class XeDuLich : Xe
    {
        public double TongTien(double sogio)
        {
            double tong = 0;
            if (sogio <= 1) tong = 250000;
            else tong = 250000 + 70000 * (sogio - 1);
            return tong;
        }
    }
}
