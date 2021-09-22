using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AeroWizard;
using ThuVien.Controller;

namespace ThuVien.DialogueBox.BackupRestore
{
    public partial class wizBackup : Form
    {
        SaoLuu bk = new SaoLuu();
        public wizBackup()
        {
            InitializeComponent();
        }

        private void landingPage_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFolder.Text))
            {
                MessageBox.Show("Vui lòng chọn đường dẫn lưu tập tin sao lưu", "Chưa chọn đường dẫn lưu file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
                return;
            }
        }

        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void backupPage_Commit(object sender, WizardPageConfirmEventArgs e)
        {
            bk.saoLuuDuLieu(txtFolder.Text);
            MessageBox.Show("Sao lưu dữ liệu thành công. vui lòng tìm tập tin sao lưu ở đường dẫn sau:" + Environment.NewLine + txtFolder.Text + "\\ThuVien.bak", "Sao lưu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
