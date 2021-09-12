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
        ThuVien.Controller.NguoiDung user = new Controller.NguoiDung();
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
                user.SignIn(txtUserName.Text, txtPassword.Text);
                this.Hide();
                ThuVien.MainGUI.frmMainGui prm = new MainGUI.frmMainGui();
                prm.ShowDialog();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmSignIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
