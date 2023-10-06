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
    public partial class FormInHoaDon : Form
    {
        public FormInHoaDon()
        {
            InitializeComponent();
        }

        private void FormInHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLSHOPDataSet.INHOADON' table. You can move, or remove it, as needed.
            this.INHOADONTableAdapter.Fill(this.QLSHOPDataSet.INHOADON);
            this.TONGHOADONTableAdapter.Fill(this.QLSHOPDataSet.TONGHOADON);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
