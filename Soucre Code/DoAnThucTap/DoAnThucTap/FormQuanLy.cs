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
    public partial class FormQuanLy : Form
    {
        public FormQuanLy()
        {
            InitializeComponent();
        }

        private void FormQuanLy_Load(object sender, EventArgs e)
        {
        }

        private Form CurrentFormchild;

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
            panelBody.Controls.Add(ChildForm);
            panelBody.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void btnBH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBanHang());
        }

        private void btnNH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNhapHang());
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNhanVien());
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormKho());
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormKhachHang());
        }
    }
}
