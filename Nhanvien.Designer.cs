namespace BTtrenLop
{
    partial class NhanVien
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
            this.txtMsnv = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblNv = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblLuong = new System.Windows.Forms.Label();
            this.btnDongy = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMsnv
            // 
            this.txtMsnv.Location = new System.Drawing.Point(242, 76);
            this.txtMsnv.Name = "txtMsnv";
            this.txtMsnv.Size = new System.Drawing.Size(126, 22);
            this.txtMsnv.TabIndex = 0;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(242, 164);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(126, 22);
            this.txtLuong.TabIndex = 1;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(242, 119);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(126, 22);
            this.txtTen.TabIndex = 2;
            // 
            // lblNv
            // 
            this.lblNv.AutoSize = true;
            this.lblNv.Location = new System.Drawing.Point(45, 32);
            this.lblNv.Name = "lblNv";
            this.lblNv.Size = new System.Drawing.Size(52, 16);
            this.lblNv.TabIndex = 3;
            this.lblNv.Text = "MSNV :";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(45, 75);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(58, 16);
            this.lblTen.TabIndex = 4;
            this.lblTen.Text = "Họ Tên :";
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Location = new System.Drawing.Point(45, 117);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(74, 16);
            this.lblLuong.TabIndex = 5;
            this.lblLuong.Text = "Lương  CB :";
            // 
            // btnDongy
            // 
            this.btnDongy.Location = new System.Drawing.Point(116, 170);
            this.btnDongy.Name = "btnDongy";
            this.btnDongy.Size = new System.Drawing.Size(75, 23);
            this.btnDongy.TabIndex = 6;
            this.btnDongy.Text = "Đồng Ý";
            this.btnDongy.UseVisualStyleBackColor = true;
            this.btnDongy.Click += new System.EventHandler(this.btnDongy_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(220, 170);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(75, 23);
            this.btnBoqua.TabIndex = 7;
            this.btnBoqua.Text = "Bỏ Qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLuong);
            this.groupBox1.Controls.Add(this.btnDongy);
            this.groupBox1.Controls.Add(this.lblTen);
            this.groupBox1.Controls.Add(this.btnBoqua);
            this.groupBox1.Controls.Add(this.lblNv);
            this.groupBox1.Location = new System.Drawing.Point(90, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 233);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 336);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtMsnv);
            this.Controls.Add(this.groupBox1);
            this.Name = "NhanVien";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMsnv;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblNv;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Button btnDongy;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
