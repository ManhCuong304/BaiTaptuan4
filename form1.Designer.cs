namespace BTtrenLop
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
            this.dt1 = new System.Windows.Forms.DataGridView();
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
            this.grp1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt1
            // 
            this.dt1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.salary});
            this.dt1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dt1.Location = new System.Drawing.Point(0, 21);
            this.dt1.Name = "dt1";
            this.dt1.RowHeadersWidth = 51;
            this.dt1.RowTemplate.Height = 24;
            this.dt1.Size = new System.Drawing.Size(622, 362);
            this.dt1.TabIndex = 0;
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.btnDong);
            this.grp1.Controls.Add(this.btnSua);
            this.grp1.Controls.Add(this.btnXoa);
            this.grp1.Controls.Add(this.btnThem);
            this.grp1.Controls.Add(this.dt1);
            this.grp1.Location = new System.Drawing.Point(87, 12);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(816, 389);
            this.grp1.TabIndex = 1;
            this.grp1.TabStop = false;
            this.grp1.Text = "Danh Sách Nhân Viên";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(699, 178);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 27);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(699, 143);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 29);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(699, 108);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 29);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(699, 74);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 28);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // id
            // 
            this.id.FillWeight = 50F;
            this.id.HeaderText = "MSNV";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // name
            // 
            this.name.FillWeight = 300F;
            this.name.HeaderText = "Tên Nhân Viên";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 160;
            // 
            // salary
            // 
            this.salary.FillWeight = 150F;
            this.salary.HeaderText = "Lương CB";
            this.salary.MinimumWidth = 6;
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            this.salary.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 450);
            this.Controls.Add(this.grp1);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
            this.grp1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dt1;
        private System.Windows.Forms.GroupBox grp1;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
    }
}

