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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to winform!");
        }

        private void bntSubmit_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên!");
                txtTen.Focus();
            }
            else if (txtLop.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập lớp!");
                txtLop.Focus();
            }
            else MessageBox.Show("Chào mừng bạn "+ txtTen.Text+ " học lớp "+ txtLop.Text);
        }
    }
}
