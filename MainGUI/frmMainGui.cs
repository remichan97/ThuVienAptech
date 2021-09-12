using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien.MainGUI
{
    public partial class frmMainGui : Form
    {
        ThuVien.Controller.NguoiDung user = new Controller.NguoiDung();
        ThuVien.Controller.Sach book = new Controller.Sach();
        public frmMainGui()
        {
            InitializeComponent();
            tooltextTrangThai.Text = "Sẵn sàng";
            DataTable bookList = book.getBookList(null);
            gridThongTinSach.DataSource = bookList;
        }

        private void frmMainGui_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult a = new DialogResult();
                a = MessageBox.Show("Bạn muốn thoát phần mềm?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    user.SignOut();
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void frmMainGui_Load(object sender, EventArgs e)
        {

        }

        private void btnDienLaiSach_Click(object sender, EventArgs e)
        {
            txtTenSach.Text = "";
            txtTacGia.Text = "";
            txtLoaiSach.Text = "";
            numSoLuong.Value = 0;
        }
    }
}
