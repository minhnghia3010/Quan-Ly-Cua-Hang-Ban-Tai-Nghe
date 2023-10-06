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
    public partial class FormNhapHang : Form
    {
        DataTable Dt = new DataTable();
        string query;

        public FormNhapHang()
        {
            InitializeComponent();
        }

        private void FormNhapHang_Load(object sender, EventArgs e)
        {
            LoadNH();
            LoadCbxMNV();
        }

        private void XulyDgvNH()
        {
            dgvNH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNH.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvNH.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            dgvNH.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 15);
            dgvNH.EnableHeadersVisualStyles = false;
            dgvNH.BorderStyle = BorderStyle.None;

            dgvNH.BackgroundColor = Color.FromArgb(255, 250, 250);
            dgvNH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNH.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);
            dgvNH.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 250, 250);
            dgvNH.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 250, 250);
            dgvNH.DefaultCellStyle.BackColor = Color.FromArgb(255, 250, 250);
            dgvNH.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 250, 250);
            dgvNH.DefaultCellStyle.SelectionBackColor = Color.FromArgb(205, 92, 92);
            dgvNH.DefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);

            dgvNH.Columns[0].Visible = false;
            dgvNH.Columns[1].Visible = false;
            dgvNH.Columns[2].HeaderText = "Nguồn Nhập";
            dgvNH.Columns[3].HeaderText = "Ngày Nhập";
            dgvNH.Columns[4].HeaderText = "Giá Nhập";
            dgvNH.Columns[5].HeaderText = "Nhân Viên";
            dgvNH.Columns[6].HeaderText = "Mã Sản Phẩm";
            dgvNH.Columns[7].HeaderText = "Số Lượng Nhập";
            dgvNH.Columns[8].HeaderText = "Tình Trạng";
        }

        private void LoadCbxNguon()
        {
            query = "select distinct NGUONNHAP from NHAP_HANG";

            cbxSNgN.DataSource = DataProvider.Instance.ExecuteQuery(query);
            cbxSNgN.DisplayMember = "NGUONNHAP";
        }

        private void LoadCbxMNV()
        {
            query = "select distinct MANV,TENNV from NHAN_VIEN";

            cbxMNV.DataSource = DataProvider.Instance.ExecuteQuery(query);
            cbxMNV.DisplayMember = "TENNV";
            cbxMNV.ValueMember = "MANV";
            txtMNV.DataBindings.Clear();
            txtMNV.DataBindings.Add("Text", cbxMNV.DataSource, "MANV");
        }

        private void LoadCbxNgay()
        {
            query = "select distinct NGAYNHAP from NHAP_HANG";

            cbxSNN.DataSource = DataProvider.Instance.ExecuteQuery(query);
            cbxSNN.DisplayMember = "NGAYNHAP";
        }

        private void LoadNH()
        {
            query = "select NHAP_HANG.MANV ,MANH, NGUONNHAP, NGAYNHAP, GIANHAP, TENNV, NHAP_HANG.MASP, SLN, NHAP_HANG.TINHTRANG " +
                "from NHAP_HANG, NHAN_VIEN, SAN_PHAM " +
                "where NHAP_HANG.MANV = NHAN_VIEN.MANV and SAN_PHAM.MASP = NHAP_HANG.MASP";

            dgvNH.DataSource = DataProvider.Instance.ExecuteQuery(query);
            XulyDgvNH();
            //Load textbox nhập hàng
            txtMASP.DataBindings.Clear();
            txtMASP.DataBindings.Add("Text", dgvNH.DataSource, "MASP");
            txtMNH.DataBindings.Clear();
            txtMNH.DataBindings.Add("Text", dgvNH.DataSource, "MANH");
            txtGN.DataBindings.Clear();
            txtGN.DataBindings.Add("Text", dgvNH.DataSource, "GIANHAP");
            txtSLN.DataBindings.Clear();
            txtSLN.DataBindings.Add("Text", dgvNH.DataSource, "SLN");
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            string a = DateTime.Today.ToString().Trim();
            query = string.Format("insert into NHAP_HANG values('{0}','{1}',{2},{3},{4},{5},N'{6}')",
                cbxSNgN.Text, a, Int64.Parse(txtGN.Text), Int32.Parse(txtMNV.Text), Int32.Parse(txtSLN.Text), Int32.Parse(txtMASP.Text), "Chưa cập nhật số lượng");

            try
            {
                DataProvider.Instance.ExecuteNonQuery(query);
                MessageBox.Show("Thêm Nhập Hàng Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormNhapHang_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Thêm Nhập Hàng Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            query = string.Format("delete from NHAP_HANG where MANH = {0}", Int16.Parse(txtMNH.Text));

            try
            {
                DataProvider.Instance.ExecuteNonQuery(query);
                MessageBox.Show("Xóa Nhập Hàng Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormNhapHang_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Xóa Nhập Hàng Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btxS_Click(object sender, EventArgs e)
        {
            query = string.Format("update NHAP_HANG set NGUONNHAP = '{0}', GIANHAP = {1}, MANV = {2}, MASP = {3} where MANH = {4}",
               cbxSNgN.Text, txtGN.Text, Int32.Parse(txtMNV.Text), Int32.Parse(txtMASP.Text), Int32.Parse(txtMNH.Text));

            try
            {
                DataProvider.Instance.ExecuteNonQuery(query);
                MessageBox.Show("Sửa Nhập Hàng Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormNhapHang_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Sửa Nhập Hàng Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTG_Click(object sender, EventArgs e)
        {

            query = string.Format("select Sum(GIANHAP*SLN) from NHAP_HANG where NGUONNHAP = N'{0}' or NGAYNHAP = '{1}'",
                cbxSNgN.Text, cbxSNN.Text);

            txtTGN.Text = string.Format("{0:#,##0.##}", Int32.Parse(DataProvider.Instance.ExecuteScalar(query).ToString())) + "  VNĐ";
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            query = "select MAX(MANH) from NHAP_HANG";
            int a = Int32.Parse(DataProvider.Instance.ExecuteScalar(query).ToString());
            string query1 = string.Format("select NHAP_HANG.MASP, SLN from NHAP_HANG, SAN_PHAM where SAN_PHAM.MASP = NHAP_HANG.MASP  and MANH = {0}", a);

            Dt = DataProvider.Instance.ExecuteQuery(query1);

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                string query2 = string.Format("update SAN_PHAM set SLTON += {0} where MASP = {1}", Dt.Rows[i].ItemArray[1].ToString(), Dt.Rows[i].ItemArray[0].ToString());
                string query3 = string.Format("update NHAP_HANG set TINHTRANG = N'Đã cập nhật số lượng' where MANH = {0}", Int32.Parse(txtMNH.Text));
                DataProvider.Instance.ExecuteNonQuery(query2);
                DataProvider.Instance.ExecuteNonQuery(query3);
                MessageBox.Show("Nhập Kho Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadNH();
        }

        private void cbxSNgN_Click(object sender, EventArgs e)
        {
            LoadCbxNguon();
            cbxSNN.Text = "";
        }

        private void cbxSNN_Click(object sender, EventArgs e)
        {
            LoadCbxNgay();
            cbxSNgN.Text = "";
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            query = string.Format("select * from NHAP_HANG where NGUONNHAP = N'{0}' or NGAYNHAP = '{1}'", cbxSNgN.Text, cbxSNN.Text);

            dgvNH.DataSource = DataProvider.Instance.ExecuteQuery(query);
            if (cbxSNgN.Text == "" && cbxSNN.Text == "")
            {
                LoadNH();
            }
        }

        private void btnINH_Click(object sender, EventArgs e)
        {
            FormInNhapHang formInNhapHang = new FormInNhapHang();
            formInNhapHang.ShowDialog();
        }
    }
}
