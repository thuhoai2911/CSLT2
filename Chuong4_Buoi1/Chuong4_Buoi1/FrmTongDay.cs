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
    public partial class FrmTongDay : Form
    {
        public FrmTongDay()
        {
            InitializeComponent();
        }

        private void FrmTongDay_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Tính tổng dãy số");
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntTongDay_Click(object sender, EventArgs e)
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
                int a = Convert.ToInt32(txtA.Text);
                int b = Convert.ToInt32(txtB.Text);
                if (a > b)
                {
                    MessageBox.Show("Nhập sai! Nhập vào a nhỏ hơn b");
                    bntLamLai_Click(sender, e);
                }
                else
                {
                    int tong = 0;
                    for (int i = a; i <= b; i++)
                        tong += i;
                    lbTongDay.Text = "Tổng dãy số từ a đến b là: " + tong.ToString();
                }    
            }     
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || Convert.ToInt32(e.KeyChar) == 8 || Convert.ToInt32(e.KeyChar) == 13)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || Convert.ToInt32(e.KeyChar) == 8 || Convert.ToInt32(e.KeyChar) == 13)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void bntLamLai_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtA.Focus();
        }
    }
}
