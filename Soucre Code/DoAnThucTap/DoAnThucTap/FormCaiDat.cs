using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThucTap
{
    public partial class FormCaiDat : Form
    {
        public FormCaiDat()
        {
            InitializeComponent();
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

        private void FormCaiDat_Load(object sender, EventArgs e)
        {
            OpenChildForm(new FormMaVach());
        }
    }
}
