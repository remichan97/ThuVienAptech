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

namespace ThuVien
{
    public partial class frmSignIn : Form
    {
        DbConnection db = new DbConnection();
        public frmSignIn()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin đăng nhập!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                SqlCommand cmd = new SqlCommand("HeThong_DangNhapHeThong", db.GetConnection());
                cmd.Parameters.AddWithValue("@TenDangNhap", txtUserName.Text);
                cmd.Parameters.AddWithValue("@MatKhau", txtPassword.Text);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                this.Hide();
                ThuVien.MainGUI.frmMainGui prm = new MainGUI.frmMainGui();
                prm.Show();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
