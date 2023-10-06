using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnThucTap.DAO;

namespace DoAnThucTap
{
    public partial class FormMain : Form
    {
        
        public FormMain()
        {
            InitializeComponent();            
        }
        string query;
        private string _message;

        private void FormMain_Load(object sender, EventArgs e)
        {
            OpenChildForm(new FormTongQuat());
            labelName.Text = btnTQ.Text;
            lbTDN.Text = _message;
        }

        private Form CurrentFormchild;

        public string Message { get => _message; set => _message = value; }

        private bool CHECKQUYEN()
        {
            bool a = true;
            query = string.Format("select QUYEN from DANG_NHAP where USERNAME = '{0}'",lbTDN.Text);
            if(Int32.Parse(DataProvider.Instance.ExecuteScalar(query).ToString()) == 0)
            {
                a = false;
            }
            return a;            
        }

        private void OpenChildForm(Form ChildForm)
        {
            if (CurrentFormchild != null)
            {
                CurrentFormchild.Close();
            }

            CurrentFormchild = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.Dock = DockStyle.Fill;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            panel_body.Controls.Add(ChildForm);
            panel_body.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }


        private void btnT_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Thông Báo", "Bạn Có Chắc Muốn Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (h == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHoaDon());
            labelName.Text = btnHD.Text;
        }

        private void btnQL_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLy());
            labelName.Text = btnQL.Text;
        }

        private void btnDT_Click(object sender, EventArgs e)
        {
            if (CHECKQUYEN() == true)
            {
                OpenChildForm(new FormDoanhThu());
                labelName.Text = btnDT.Text;
            }
            else if (CHECKQUYEN() == false)
            {
                MessageBox.Show("Hãy Đăng Nhập Dưới Quyền Quản Trị Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTQ_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTongQuat());
            labelName.Text = btnTQ.Text;
        }

        private void btnCD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCaiDat());
            labelName.Text = btnCD.Text;
        }

        private void btnDL_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDuLieu());
            labelName.Text = btnDL.Text;
        }

        private void buttonDX_Click(object sender, EventArgs e)
        {
            this.Close();
            FormDangNhap formDangNhap = new FormDangNhap();
            formDangNhap.Show();
        }

        private void lbTDN_Click(object sender, EventArgs e)
        {

        }
    }
}
