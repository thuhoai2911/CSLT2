namespace Chuong4_Buoi1
{
    partial class FrmTinhTong
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
            this.lbA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lbB = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lbTong = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.bntTinhTong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbA.Location = new System.Drawing.Point(159, 69);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(28, 25);
            this.lbA.TabIndex = 0;
            this.lbA.Text = "a:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(249, 69);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 26);
            this.txtA.TabIndex = 1;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbB.Location = new System.Drawing.Point(159, 129);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(29, 25);
            this.lbB.TabIndex = 0;
            this.lbB.Text = "b:";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(249, 129);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 26);
            this.txtB.TabIndex = 1;
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_KeyPress);
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTong.Location = new System.Drawing.Point(159, 271);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(63, 25);
            this.lbTong.TabIndex = 0;
            this.lbTong.Text = "Tổng:";
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(249, 271);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(100, 26);
            this.txtTong.TabIndex = 1;
            // 
            // bntTinhTong
            // 
            this.bntTinhTong.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntTinhTong.Location = new System.Drawing.Point(194, 186);
            this.bntTinhTong.Name = "bntTinhTong";
            this.bntTinhTong.Size = new System.Drawing.Size(126, 54);
            this.bntTinhTong.TabIndex = 2;
            this.bntTinhTong.Text = "Tính tổng";
            this.bntTinhTong.UseVisualStyleBackColor = true;
            this.bntTinhTong.Click += new System.EventHandler(this.bntTinhTong_Click);
            // 
            // FrmTinhTong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntTinhTong);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.lbTong);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lbA);
            this.Name = "FrmTinhTong";
            this.Text = "FrmTinhTong";
            this.Load += new System.EventHandler(this.FrmTinhTong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Button bntTinhTong;
    }
}