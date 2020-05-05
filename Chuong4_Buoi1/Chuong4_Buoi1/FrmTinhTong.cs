using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chuong4_Buoi1
{
    public partial class FrmTinhTong : Form
    {
        public FrmTinhTong()
        {
            InitializeComponent();
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '.' || Convert.ToInt32(e.KeyChar) == 8 || Convert.ToInt32(e.KeyChar) == 13)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '.' || Convert.ToInt32(e.KeyChar) == 8 || Convert.ToInt32(e.KeyChar) == 13)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void bntTinhTong_Click(object sender, EventArgs e)
        {
            if (txtA.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số a!");
                txtA.Focus();
            }
            else if (txtB.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số b!");
                txtB.Focus();
            }
            else
            {
                double a = Convert.ToDouble(txtA.Text);
                double b = Convert.ToDouble(txtB.Text);
                double tong = a + b;
                txtTong.Text = tong.ToString();
            }               
        }

        private void FrmTinhTong_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Tính tổng 2 số");
        }
    }
}
