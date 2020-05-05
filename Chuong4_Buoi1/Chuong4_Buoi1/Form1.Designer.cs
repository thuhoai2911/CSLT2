namespace Chuong4_Buoi1
{
    partial class Form1
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
            this.lbTen = new System.Windows.Forms.Label();
            this.lbLop = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.bntSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(70, 37);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(36, 20);
            this.lbTen.TabIndex = 0;
            this.lbTen.Text = "Tên";
            // 
            // lbLop
            // 
            this.lbLop.AutoSize = true;
            this.lbLop.Location = new System.Drawing.Point(70, 91);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(36, 20);
            this.lbLop.TabIndex = 1;
            this.lbLop.Text = "Lớp";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(179, 34);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 26);
            this.txtTen.TabIndex = 2;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(179, 91);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(100, 26);
            this.txtLop.TabIndex = 2;
            // 
            // bntSubmit
            // 
            this.bntSubmit.Location = new System.Drawing.Point(300, 215);
            this.bntSubmit.Name = "bntSubmit";
            this.bntSubmit.Size = new System.Drawing.Size(135, 64);
            this.bntSubmit.TabIndex = 3;
            this.bntSubmit.Text = "Submit";
            this.bntSubmit.UseVisualStyleBackColor = true;
            this.bntSubmit.Click += new System.EventHandler(this.bntSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntSubmit);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lbLop);
            this.Controls.Add(this.lbTen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbLop;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.Button bntSubmit;
    }
}

