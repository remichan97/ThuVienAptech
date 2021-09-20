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

namespace ThuVien.DialogueBox.LostBook
{
	public partial class frmLostBook : Form
	{
		SinhVien sv = new SinhVien();
		TraSach traSach = new TraSach();
		public frmLostBook()
		{
			InitializeComponent();
		}

		private void loadData()
		{
			DataTable student = sv.GetStudentList(null);
			comboBox1.DataSource = student;
			comboBox1.DisplayMember = "TenSinhVien";
			comboBox1.ValueMember = "MaSinhVien";
			comboBox1.SelectedIndex = -1;
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (comboBox1.SelectedIndex == -1)
			{
				MessageBox.Show("Vui lòng chọn sinh viên để tìm kiếm thông tin!", "Chưa chọn sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			comboBox1.SelectedIndex = -1;
			dateTimePicker1.Value = DateTime.Now;
			dateTimePicker2.Value = DateTime.Now;
			DataTable empty = traSach.timKiemThongTinNguoiMuon(null, null, null);
			dataGridView1.DataSource = empty;
		}

		private void btnReportLost_Click(object sender, EventArgs e)
		{
			Dictionary<int, int> lostBooks = new Dictionary<int, int>();
			for (int i = 0; i < dataGridView1.Rows.Count; i++)
			{
				if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0]) && dataGridView1.Rows[i].Cells[1].Value != null)
				{
					lostBooks.Add(Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value), Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value));
				}
			}

			if (lostBooks.Count != 0)
			{
				try
				{
					traSach.baoMatSach(lostBooks, comboBox1.SelectedValue.ToString(), DateTime.Today.ToShortDateString(), dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
                    MessageBox.Show("Đã báo mất sách thành công", "Thành công");
                    this.Hide();
				}
				catch (SqlException ex)
				{
					MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
            else
            {
                MessageBox.Show("Không có sách nào được báo mất. Vui lòng kiểm tra lại dữ liệu nhập vào.", "Không có sách nào báo mất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

		}

		private void frmLostBook_Load(object sender, EventArgs e)
		{
			loadData();
		}
	}
}
