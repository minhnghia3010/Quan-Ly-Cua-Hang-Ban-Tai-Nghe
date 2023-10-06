using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DoAnThucTap.DAO;

namespace DoAnThucTap
{
    public partial class FormDangNhap : Form
    {

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        bool login(string username, string password)
        {
            return accountDAO.Instance.login(username, password);
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            try
            {
                if (login(txtTDN.Text, txtMK.Text))
                {
                    this.Hide();
                    MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormMain formMain = new FormMain();
                    formMain.Message = txtTDN.Text;
                    formMain.Show();
                }
                else
                {
                    MessageBox.Show("Đăng Nhập Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Đăng Nhập Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            FormDangKy formDangKy = new FormDangKy();
            formDangKy.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormQuenMatKhau formQuenMatKhau = new FormQuenMatKhau();
            formQuenMatKhau.ShowDialog();
        }

        private void txtTDN_Click(object sender, EventArgs e)
        {
            if (txtTDN.Text == "Nhập Tên Đăng Nhập")
            {
                txtTDN.Text = "";
            }
        }

        private void txtMK_Click(object sender, EventArgs e)
        {
            if (txtMK.Text == "Mật Khẩu")
            {
                txtMK.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void txtTDN_Leave(object sender, EventArgs e)
        {
            if (txtTDN.Text == "")
            {
                txtTDN.Text = "Nhập Tên Đăng Nhập";
            }
        }

        private void txtMK_Leave(object sender, EventArgs e)
        {
            if (txtMK.Text == "")
            {
                txtMK.Text = "";
            }
        }

        private void btnQR_Click(object sender, EventArgs e)
        {
            FormDNQR formqr = new FormDNQR();
            formqr.Show();
            this.Hide();
        }
    }
}
