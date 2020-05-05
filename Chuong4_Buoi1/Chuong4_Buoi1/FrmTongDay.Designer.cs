namespace Chuong4_Buoi1
{
    partial class FrmTongDay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bntTongDay = new System.Windows.Forms.Button();
            this.bntLamLai = new System.Windows.Forms.Button();
            this.bntThoat = new System.Windows.Forms.Button();
            this.lbA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lbB = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lbTongDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntTongDay
            // 
            this.bntTongDay.Location = new System.Drawing.Point(118, 292);
            this.bntTongDay.Name = "bntTongDay";
            this.bntTongDay.Size = new System.Drawing.Size(151, 63);
            this.bntTongDay.TabIndex = 0;
            this.bntTongDay.Text = "Tính Tổng";
            this.bntTongDay.UseVisualStyleBackColor = true;
            this.bntTongDay.Click += new System.EventHandler(this.bntTongDay_Click);
            // 
            // bntLamLai
            // 
            this.bntLamLai.Location = new System.Drawing.Point(308, 292);
            this.bntLamLai.Name = "bntLamLai";
            this.bntLamLai.Size = new System.Drawing.Size(151, 63);
            this.bntLamLai.TabIndex = 1;
            this.bntLamLai.Text = "Làm lại";
            this.bntLamLai.UseVisualStyleBackColor = true;
            this.bntLamLai.Click += new System.EventHandler(this.bntLamLai_Click);
            // 
            // bntThoat
            // 
            this.bntThoat.Location = new System.Drawing.Point(500, 292);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(151, 63);
            this.bntThoat.TabIndex = 1;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(102, 58);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(64, 20);
            this.lbA.TabIndex = 2;
            this.lbA.Text = "Nhập a:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(230, 58);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 26);
            this.txtA.TabIndex = 3;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Location = new System.Drawing.Point(102, 122);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(64, 20);
            this.lbB.TabIndex = 2;
            this.lbB.Text = "Nhập b:";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(230, 122);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 26);
            this.txtB.TabIndex = 3;
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_KeyPress);
            // 
            // lbTongDay
            // 
            this.lbTongDay.AutoSize = true;
            this.lbTongDay.Location = new System.Drawing.Point(102, 189);
            this.lbTongDay.Name = "lbTongDay";
            this.lbTongDay.Size = new System.Drawing.Size(0, 20);
            this.lbTongDay.TabIndex = 4;
            // 
            // FrmTongDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTongDay);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lbA);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.bntLamLai);
            this.Controls.Add(this.bntTongDay);
            this.Name = "FrmTongDay";
            this.Text = "FrmTongDay";
            this.Load += new System.EventHandler(this.FrmTongDay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntTongDay;
        private System.Windows.Forms.Button bntLamLai;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lbTongDay;
    }
}