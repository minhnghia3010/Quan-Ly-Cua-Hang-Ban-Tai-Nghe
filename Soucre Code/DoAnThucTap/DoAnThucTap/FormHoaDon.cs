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
    public partial class FormHoaDon : Form
    {
        string query;
        DataTable Dt = new DataTable();

        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            LoadHD();
            LoadCbxNV();
        }

        private void TinhTongTien()
        {
            int sc = dgvHD.Rows.Count;
            int thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += int.Parse(dgvHD.Rows[i].Cells["THANHTIEN"].Value.ToString());
            txtTT.Text = string.Format("{0:#,##0.##}", Int32.Parse(thanhtien.ToString())) + "  VNĐ";
        }

        private void XulyDgvK()
        {
            dgvHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHD.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvHD.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            dgvHD.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 15);
            dgvHD.EnableHeadersVisualStyles = false;
            dgvHD.BorderStyle = BorderStyle.None;

            dgvHD.BackgroundColor = Color.FromArgb(255, 250, 250);
            dgvHD.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHD.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);
            dgvHD.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 250, 250);
            dgvHD.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 250, 250);
            dgvHD.DefaultCellStyle.BackColor = Color.FromArgb(255, 250, 250);
            dgvHD.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 250, 250);
            dgvHD.DefaultCellStyle.SelectionBackColor = Color.FromArgb(205, 92, 92);
            dgvHD.DefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);

            dgvHD.Columns[0].HeaderText = "Tên Sản Phẩm";
            dgvHD.Columns[1].HeaderText = "Loại Tai Nghe";
            dgvHD.Columns[2].HeaderText = "Màu";
            dgvHD.Columns[3].HeaderText = "Thời Lượng Pin";
            dgvHD.Columns[4].HeaderText = "Số Lượng";
            dgvHD.Columns[5].HeaderText = "Giá";
            dgvHD.Columns[6].HeaderText = "Mã Giảm Giá (%)";
            dgvHD.Columns[7].HeaderText = "Thành Tiền";
        }

        private void LoadHD()
        {
            query = "exec dbo.LOADHD";
            string query1 = "SELECT MAX(MAHD) FROM HOA_DON";
            txtMHD.Text = DataProvider.Instance.ExecuteScalar(query1).ToString();

            dgvHD.DataSource = DataProvider.Instance.ExecuteQuery(query);
            XulyDgvK();

            txtCL.DataBindings.Clear();
            txtCL.DataBindings.Add("Text", dgvHD.DataSource, "THOILUONGPIN");
            txtG.DataBindings.Clear();
            txtG.DataBindings.Add("Text", dgvHD.DataSource, "GIA");
            txtM.DataBindings.Clear();
            txtM.DataBindings.Add("Text", dgvHD.DataSource, "MAU");
            txtTSP.DataBindings.Clear();
            txtTSP.DataBindings.Add("Text", dgvHD.DataSource, "TENSP");
            txtS.DataBindings.Clear();
            txtS.DataBindings.Add("Text", dgvHD.DataSource, "LOAITN");
            txtSOGG.DataBindings.Clear();
            txtSOGG.DataBindings.Add("Text", dgvHD.DataSource, "SOGG");

            TinhTongTien();
        }

        private void LoadCbxNV()
        {
            query = "select TENNV, MANV from NHAN_VIEN";

            cbxTNV.DataSource = DataProvider.Instance.ExecuteQuery(query);
            cbxTNV.DisplayMember = "TENNV";
            cbxTNV.ValueMember = "MANV";

            txtMNV.DataBindings.Clear();
            txtMNV.DataBindings.Add("Text", cbxTNV.DataSource, "MANV");
        }

        private void LoadTxtKH()
        {
            query = string.Format("select MAKH, TENKH from KHACH_HANG where SDT = '{0}'",txtSDT.Text);

            Dt = DataProvider.Instance.ExecuteQuery(query);

            txtMKH.DataBindings.Clear();
            txtMKH.DataBindings.Add("Text", Dt, "MAKH");
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            FormInHoaDon formInHoaDon = new FormInHoaDon();
            formInHoaDon.ShowDialog();
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            
            try
            {
                LoadTxtKH();
                if (txtSDT.Text != "")
                {
                    query = string.Format("update HOA_DON set MAKH = {0}, MANV = {1}, NGAYXUAT = '{2}' where MAHD = {3}", Int32.Parse(txtMKH.Text), Int32.Parse(txtMNV.Text), DateTime.Now.ToString().Trim(), Int32.Parse(txtMHD.Text));

                    try
                    {
                        DataProvider.Instance.ExecuteQuery(query);
                        MessageBox.Show("Thêm Thông Tin Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadHD();
                    }
                    catch
                    {
                        MessageBox.Show("Thêm Thông Tin Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    LoadHD();
                }
                else
                {
                    MessageBox.Show("Vui Lòng Nhập Số Điện Thoại Khách Hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Khách Hàng Mới", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void btnKT_Click(object sender, EventArgs e)
        {
            query = string.Format("select TENSP, THOILUONGPIN, MAU, LOAITN, SOLUONG, GIA, SOGG, THANHTIEN, TENKH, DIACHI, TENNV " +
                "from HOA_DON, SAN_PHAM, GIAM_GIA, CHI_TIET_HOA_DON, KHACH_HANG, NHAN_VIEN " +
                "where HOA_DON.MAHD = CHI_TIET_HOA_DON.MAHD and SAN_PHAM.MASP = CHI_TIET_HOA_DON.MASP and GIAM_GIA.MAGG = SAN_PHAM.MAGG " +
                "and KHACH_HANG.MAKH = HOA_DON.MAKH and NHAN_VIEN.MANV = HOA_DON.MANV and HOA_DON.MAHD = {0}",Int32.Parse(txtMHD.Text));

            dgvHD.DataSource = DataProvider.Instance.ExecuteQuery(query);
            XulyDgvK();
            dgvHD.Columns[8].HeaderText = "Tên Khách Hàng";
            dgvHD.Columns[9].HeaderText = "Địa Chỉ";
            dgvHD.Columns[10].HeaderText = "Tên Nhân Viên";
            txtDC.DataBindings.Clear();
            txtDC.DataBindings.Add("Text", dgvHD.DataSource, "DIACHI");
        }
    }
}
