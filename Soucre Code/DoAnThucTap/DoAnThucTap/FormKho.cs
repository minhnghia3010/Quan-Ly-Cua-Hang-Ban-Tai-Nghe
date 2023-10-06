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
    public partial class FormKho : Form
    {
        string query;

        public FormKho()
        {
            InitializeComponent();
        }

        private void FormKho_Load(object sender, EventArgs e)
        {
            LoadK();
            TinhTrang();
        }

        private void XulyDgvK()
        {
            dgvK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvK.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvK.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            dgvK.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 15);
            dgvK.EnableHeadersVisualStyles = false;
            dgvK.BorderStyle = BorderStyle.None;

            dgvK.BackgroundColor = Color.FromArgb(255, 250, 250);
            dgvK.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvK.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);
            dgvK.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 250, 250);
            dgvK.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 250, 250);
            dgvK.DefaultCellStyle.BackColor = Color.FromArgb(255, 250, 250);
            dgvK.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 250, 250);
            dgvK.DefaultCellStyle.SelectionBackColor = Color.FromArgb(205, 92, 92);
            dgvK.DefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);

            dgvK.Columns[0].HeaderText = "Mã Sản Phẩm";
            dgvK.Columns[1].HeaderText = "Tên Sản Phẩm";
            dgvK.Columns[2].HeaderText = "Màu";
            dgvK.Columns[3].HeaderText = "Loại Tai Nghe";
            dgvK.Columns[4].HeaderText = "Số Lượng Tồn";
            dgvK.Columns[5].HeaderText = "Tình Trạng";

        }

        private void LoadK()
        {
            query = "select MASP, TENSP, MAU, LOAITN, SLTON, TINHTRANG from SAN_PHAM";
            
            dgvK.DataSource = DataProvider.Instance.ExecuteQuery(query);
            XulyDgvK();
            //Load textbox nhập hàng
            txtMSP.DataBindings.Clear();
            txtMSP.DataBindings.Add("Text", dgvK.DataSource, "MASP");
            txtSLN.DataBindings.Clear();
            txtSLN.DataBindings.Add("Text", dgvK.DataSource, "SLTON");
            txtTT.DataBindings.Clear();
            txtTT.DataBindings.Add("Text", dgvK.DataSource, "TINHTRANG");
        }

        private void TinhTrang()
        {
            query = "update SAN_PHAM set TINHTRANG = N'Đủ' where SLTON > 50";

            DataProvider.Instance.ExecuteNonQuery(query);
            LoadK();
        }
    }
}
