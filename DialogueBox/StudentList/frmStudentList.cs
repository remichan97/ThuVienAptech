using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVien.Controller;

namespace ThuVien.DialogueBox
{
	public partial class frmStudentList : Form
	{
		SinhVien sv = new SinhVien();
		public frmStudentList()
		{
			InitializeComponent();
		}

		private void loadData()
		{
			DataTable stdList = sv.GetStudentList(null);
			gridDanhSachSinhVien.DataSource = stdList;
			gridDanhSachSinhVien.ClearSelection();
            DataTable gioiTinh = sv.GetGenderOptions();
            cmbGioiTinh.DataSource = gioiTinh;
            cmbGioiTinh.DisplayMember = "GioiTinhDich";
            cmbGioiTinh.ValueMember = "GioiTinh";
		}

		private void btnSearchStudent_Click(object sender, EventArgs e)
		{
            if (string.IsNullOrEmpty(txtSearchStudent.Text))
            {
                loadData();
            }
            else
            {
                DataTable stdList = sv.GetStudentList(txtSearchStudent.Text);
                gridDanhSachSinhVien.DataSource = stdList;
                gridDanhSachSinhVien.ClearSelection();
            }
		}

		private void btnAddStudent_Click(object sender, EventArgs e)
		{
            if (string.IsNullOrEmpty(txtTenSinhVien.Text) || string.IsNullOrEmpty(txtMaSinhVien.Text) || string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng điền các thông tin cần thiết để tiến hành thêm thông tin sinh viên", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                sv.addStudent(txtMaSinhVien.Text, txtTenSinhVien.Text, txtDiaChi.Text, Convert.ToInt32(cmbGioiTinh.SelectedValue));
                MessageBox.Show("Thêm thông tin sinh viên thành công", "Thành công");
                loadData();
                btnResetStudent_Click(null, null);
            }
            catch (SqlException ex)
            {
                 MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
		}

		private void btnEditStudent_Click(object sender, EventArgs e)
		{
            if (string.IsNullOrEmpty(txtTenSinhVien.Text) || string.IsNullOrEmpty(txtMaSinhVien.Text) || string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng chọn thông tin sinh viên cần tiến hành sửa dữ liệu", "Chưa chọn sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                DataGridViewRow row = gridDanhSachSinhVien.CurrentRow;
                string MaSVCu = row.Cells[0].Value.ToString();
                sv.editStudent(MaSVCu, txtMaSinhVien.Text, txtTenSinhVien.Text, txtDiaChi.Text, Convert.ToInt32(cmbGioiTinh.SelectedValue));
                MessageBox.Show("Cập nhật thông tin thành công", "Sửa thông tin");
                loadData();
                btnResetStudent_Click(null, null);
            }
            catch (SqlException ex)
            {
                 MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
		}

		private void btnDeleteStudent_Click(object sender, EventArgs e)
		{
            if (string.IsNullOrEmpty(txtTenSinhVien.Text) || string.IsNullOrEmpty(txtMaSinhVien.Text) || string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng chọn thông tin sinh viên cần ", "Chưa chọn sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                DataGridViewRow row = gridDanhSachSinhVien.CurrentRow;

                string MaSV = row.Cells[0].Value.ToString();

                sv.deleteStudent(MaSV);
                MessageBox.Show("Đã xóa thông tin sinh viên", "Xóa");
                loadData();
                btnResetStudent_Click(null, null);
            }
            catch (SqlException ex)
            {
                 MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 
            }
		}

		private void btnResetStudent_Click(object sender, EventArgs e)
		{
            txtMaSinhVien.Text = "";
            txtTenSinhVien.Text = "";
            txtDiaChi.Text = "";
            cmbGioiTinh.SelectedIndex = 0;
		}

		private void gridDanhSachSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = gridDanhSachSinhVien.CurrentRow;
				txtMaSinhVien.Text = row.Cells[0].Value.ToString();
				txtTenSinhVien.Text = row.Cells[1].Value.ToString();
				txtDiaChi.Text = row.Cells[2].Value.ToString();
				cmbGioiTinh.SelectedIndex = cmbGioiTinh.FindStringExact(row.Cells[3].Value.ToString());
			}
		}

		private void frmStudentList_Load(object sender, EventArgs e)
		{
            loadData();
		}
	}
}
