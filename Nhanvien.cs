using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static BTtrenLop.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTtrenLop
{
    public partial class NhanVien : Form
    {
        private Form1 _form1;
        private int _rowIndex;


        public NhanVien(Form1 form1, string id = "", string name = "", string salary = "", int rowIndex = -1)
        {
            InitializeComponent();
            _form1 = form1;
            _rowIndex = rowIndex;
            if (!string.IsNullOrEmpty(name))
            {
                txtMsnv.Text = id;
                txtTen.Text = name;
                txtLuong.Text = salary;
            }
        }


        private void button2_Click(object sender, EventArgs e)//Thoát khi chọn bỏ qua
        {
            this.Close();
        }
        private void btnDongy_Click(object sender, EventArgs e)
        {
            string id = txtMsnv.Text;
            string name = txtTen.Text;
            string salary = txtLuong.Text;

            _form1.AddEmployee(id, name, salary, _rowIndex);//Gọi hàm thêm hoặc sửa nhân viên
            this.Close();
        }



    }
}
