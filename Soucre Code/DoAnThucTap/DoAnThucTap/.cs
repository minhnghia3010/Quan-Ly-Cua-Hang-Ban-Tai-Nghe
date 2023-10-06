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
namespace DACS2
{
    public partial class FormDangNhap : Form
    {
        string strconn = "";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dtr;

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            connCSDL();
        }

        void connCSDL()
        {
            strconn = global::DACS2.Properties.Settings.Default.QLSHOPConnectionString;
            conn = new SqlConnection(strconn);
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            FormDangKy formDangKy = new FormDangKy();
            formDangKy.ShowDialog();
            
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            string sqlquery = "Select USERNAME, PASSWORD FROM DANG_NHAP where USERNAME = '" + txtTDN.Text + "'" + "and PASSWORD = '" + txtMK.Text + "'";
            cmd = new SqlCommand(sqlquery, conn);
            conn.Open();
            dtr = cmd.ExecuteReader();
            if(dtr.Read() == true)
            {                
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                FormTongQuat formTongQuat = new FormTongQuat();
                formTongQuat.Show();               
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
        }

        private void lblQMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormQuenMatKhau formQuenMatKhau = new FormQuenMatKhau();
            formQuenMatKhau.ShowDialog();
        }
    }
}
