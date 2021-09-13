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

namespace ThuVien.DialogueBox.PasswordChange
{
    public partial class frmPasswordChange : Form
    {
        NguoiDung user = new NguoiDung();
        public frmPasswordChange()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOldPassword.Text) || string.IsNullOrEmpty(txtNewPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các thông tin cần thiết để tiến hành đổi mật khẩu!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtNewPassword.Text != txtVerify.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không khớp! Vui lòng kiểm tra lại.", "Xác nhận không khớp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                user.changePassword(txtOldPassword.Text, txtNewPassword.Text);
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
            catch (SqlException ex)
            {
                 MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
