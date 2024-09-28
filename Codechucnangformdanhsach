using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTtrenLop
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanVien frm = new NhanVien(this);
            frm.Show();
        }
        public void AddEmployee(string id, string name, string salary, int rowIndex = -1)
        {
            if (rowIndex >= 0)
            {
                dt1.Rows[rowIndex].Cells["ID"].Value = id;
                dt1.Rows[rowIndex].Cells["NAME"].Value =name;
                dt1.Rows[rowIndex].Cells["SALARY"].Value = salary;
            }
            else
            {
                dt1.Rows.Add(id, name, salary,rowIndex);
            }
        }


        
        private void btnDong_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (dt1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dt1.SelectedRows)
                {
                    dt1.Rows.RemoveAt(row.Index);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dt1.SelectedRows.Count > 0)
            {
                var selectedRow = dt1.SelectedRows[0];
                string id = selectedRow.Cells["id"].Value?.ToString() ?? "";
                string name = selectedRow.Cells["name"].Value?.ToString() ?? "";
                string salary = selectedRow.Cells["salary"].Value?.ToString() ?? "";
                int rowIndex = selectedRow.Index;

                NhanVien frm = new NhanVien(this, id, name, salary, rowIndex);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa.");
            }
        }

    }
}
