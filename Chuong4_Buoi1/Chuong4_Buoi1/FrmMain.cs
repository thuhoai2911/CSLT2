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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 c1 = new Form1();
            c1.Show();
        }

        private void tinhTongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTinhTong c2 = new FrmTinhTong();
            c2.Show();
        }

        private void tongDayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTongDay c3 = new FrmTongDay();
            c3.Show();
        }
    }
}
