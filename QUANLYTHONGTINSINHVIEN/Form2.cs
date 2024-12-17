using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYTHONGTINSINHVIEN.Models;

namespace QUANLYTHONGTINSINHVIEN
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                var context = new Model1();
                List<Faculty> listFalcultys = context.Faculties.ToList();
                BindGrid(listFalcultys);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BindGrid(List<Faculty> listFalcultys)
        {
            dgvFaculty.Rows.Clear();
            foreach (var item in listFalcultys)
            {
                int index = dgvFaculty.Rows.Add();
                dgvFaculty.Rows[index].Cells[0].Value = item.FacultyID;
                dgvFaculty.Rows[index].Cells[1].Value = item.FacultyName;
            }
        }

        private void addAndF_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFacultyID.Text == "" || txtFacultyName.Text == "") throw new Exception("Vui long nhap day du thong tin sinh vien!");
                int selectedRow = GetSelectedRow(txtStudentID.Text);
                if (selectedRow == -1)
                {
                    selectedRow = dgvStudent.Rows.Add();
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Them du lieu thanh cong!", "Thong bao", MessageBoxButtons.OK);
                }
                else
                {
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Cap nhat du lieu thanh cong!", "Thong bao", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

