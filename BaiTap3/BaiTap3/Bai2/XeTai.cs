using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiTap3.Bai2
{
    class XeTai : Xe
    {
        public double TongTien(double sogio)
        {
            double tong = 0;
            if (sogio <= 1) tong = 220000;
            else tong = 220000 + 85000 * (sogio - 1);
            return tong;
        }
    }
}
