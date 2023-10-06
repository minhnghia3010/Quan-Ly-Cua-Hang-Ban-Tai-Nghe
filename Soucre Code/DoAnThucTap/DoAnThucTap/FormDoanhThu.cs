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
    public partial class FormDoanhThu : Form
    {
        string query;

        public FormDoanhThu()
        {
            InitializeComponent();
        }

        private void FormDoanhThu_Load(object sender, EventArgs e)
        {
            loadDT();
            LoadCbxNTN();
            LoadCbxTh();
            LoadCbxN();
            chartT();
            TongThuNhap();
            TongGiaNhap();
            TongLN();
        }

        private void XulyDgvDT()
        {
            dgvDT.BorderStyle = BorderStyle.None;
            dgvDT.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvDT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDT.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            dgvDT.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 15);
            dgvDT.EnableHeadersVisualStyles = false;
            dgvDT.BorderStyle = BorderStyle.None;

            dgvDT.BackgroundColor = Color.FromArgb(255, 250, 250);
            dgvDT.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDT.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);
            dgvDT.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 250, 250);
            dgvDT.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 250, 250);
            dgvDT.DefaultCellStyle.BackColor = Color.FromArgb(255, 250, 250);
            dgvDT.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 250, 250);
            dgvDT.DefaultCellStyle.SelectionBackColor = Color.FromArgb(205, 92, 92);
            dgvDT.DefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);

            dgvDT.Columns[0].Visible = false;
            dgvDT.Columns[1].HeaderText = "Tên Sản Phảm";
            dgvDT.Columns[2].HeaderText = "Màu";
            dgvDT.Columns[3].HeaderText = "Loại Tai Nghe";
            dgvDT.Columns[4].HeaderText = "Thời Lượng Pin";
            dgvDT.Columns[5].HeaderText = "Ngày Xuất";
            dgvDT.Columns[6].HeaderText = "Thành Tiền";
        }

        private void loadDT()
        {
            query = "select HOA_DON.MAHD, TENSP, MAU, LOAITN, THOILUONGPIN, NGAYXUAT , THANHTIEN " +
                "from HOA_DON, CHI_TIET_HOA_DON, SAN_PHAM " +
                "where HOA_DON.MAHD = CHI_TIET_HOA_DON.MAHD and CHI_TIET_HOA_DON.MASP = SAN_PHAM.MASP";

            dgvDT.DataSource = DataProvider.Instance.ExecuteQuery(query);
            XulyDgvDT();
        }

        private void LoadCbxN()
        {
            query = "select distinct YEAR(NGAYXUAT) as NAM from HOA_DON ";

            cbxN.DataSource = DataProvider.Instance.ExecuteQuery(query);
            cbxN.DisplayMember = "NAM";
        }

        private void LoadCbxTh()
        {
            query = "select distinct MONTH(NGAYXUAT) as THANG from HOA_DON ";

            cbxT.DataSource = DataProvider.Instance.ExecuteQuery(query);
            cbxT.DisplayMember = "THANG";
            cbxT.Text = "";
        }

        private void LoadCbxNTN()
        {
            query = "select distinct NGAYXUAT from HOA_DON";

            cbxNNT.DataSource = DataProvider.Instance.ExecuteQuery(query);
            cbxNNT.DisplayMember = "NGAYXUAT";
            cbxNNT.Text = "";
        }

        private void TinhTongTien()
        {
            int sc = dgvDT.Rows.Count;
            int thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += int.Parse(dgvDT.Rows[i].Cells["THANHTIEN"].Value.ToString());
            txtTDT.Text = string.Format("{0:#,##0.##}", Int32.Parse(thanhtien.ToString())) + "  VNĐ";
        }
        private void TongThuNhap()
        {
            query = "select sum(THANHTIEN) from CHI_TIET_HOA_DON";
            if (DataProvider.Instance.ExecuteScalar(query) != null)
            {
                int num;
                num = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
                txtTT.Text = string.Format("{0:#,##0.##}", Int32.Parse(num.ToString()))+" VND";
            }
        }
        private void TongGiaNhap()
        {
            query = "select sum(GIANHAP*SLN) from NHAP_HANG";
            if (DataProvider.Instance.ExecuteScalar(query) != null)
            {
                int num;
                num =  Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
                txtGN.Text = string.Format("{0:#,##0.##}", Int32.Parse(num.ToString()))+" VND";
            }
        }
    
        private void TongLN()
        {
            int ln;
            query = "exec dbo.TINHLOINHUAN";
            ln = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            txtLN.Text = string.Format("{0:#,##0.##}", Int32.Parse(ln.ToString()))+" VND";
        }
        private void chartT()
        {
            query = string.Format("select SUM(THANHTIEN) as TONGTIEN, MONTH(NGAYXUAT) as THANG from CHI_TIET_HOA_DON, HOA_DON " +
                "where HOA_DON.MAHD = CHI_TIET_HOA_DON.MAHD and YEAR(NGAYXUAT) = '{0}' group by MONTH(NGAYXUAT)", cbxN.Text);

            chart1.DataSource = DataProvider.Instance.ExecuteQuery(query);
            chart1.Series["DoanhThu"].XValueMember = "THANG";
            chart1.Series["DoanhThu"].YValueMembers = "TONGTIEN";
            chart1.Titles.Clear();
            chart1.BackColor = Color.FromArgb(255, 250, 250);

            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
        }

        private void chartN()
        {
            query = "select SUM(THANHTIEN) as TONGTIEN, YEAR(NGAYXUAT) as NAM from CHI_TIET_HOA_DON, HOA_DON " +
                "where HOA_DON.MAHD = CHI_TIET_HOA_DON.MAHD  group by YEAR(NGAYXUAT)";

            chart1.DataSource = DataProvider.Instance.ExecuteQuery(query);
            chart1.Series["DoanhThu"].XValueMember = "NAM";
            chart1.Series["DoanhThu"].YValueMembers = "TONGTIEN";
            chart1.Titles.Clear();
            chart1.BackColor = Color.FromArgb(255, 250, 250);

            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
        }


        private void cbxT_Click(object sender, EventArgs e)
        {
            cbxNNT.Text = "";
        }

        private void cbxNNT_Click(object sender, EventArgs e)
        {
            cbxT.Text = "";
        }

        private void btnLBD_Click(object sender, EventArgs e)
        {
            if (btnLBD.Text == "BIỂU ĐỒ THÁNG")
            {
                btnLBD.Text = "BIỂU ĐỒ NĂM";
                chartN();
                lbLBD.Text = "BIỂU ĐỒ THEO NĂM";
                cbxN.Enabled = false;
            }
            else if (btnLBD.Text == "BIỂU ĐỒ NĂM")
            {
                btnLBD.Text = "BIỂU ĐỒ THÁNG";
                chartT();
                lbLBD.Text = "BIỂU ĐỒ THEO THÁNG";
                cbxN.Enabled = true;
            }
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            if (cbxNNT.Text == "" && cbxT.Text == "")
            {
                loadDT();
            }
            if (cbxNNT.Text != "")
            {
                query = string.Format("select HOA_DON.MAHD, TENSP, MAU, LOAITN, THOILUONGPIN, NGAYXUAT , THANHTIEN " +
                "from HOA_DON, CHI_TIET_HOA_DON, SAN_PHAM " +
                "where HOA_DON.MAHD = CHI_TIET_HOA_DON.MAHD and CHI_TIET_HOA_DON.MASP = SAN_PHAM.MASP and NGAYXUAT = '{0}'", cbxNNT.Text);

                dgvDT.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            else
            {
                query = string.Format("select HOA_DON.MAHD, TENSP, MAU, LOAITN, THOILUONGPIN, NGAYXUAT , THANHTIEN " +
               "from HOA_DON, CHI_TIET_HOA_DON, SAN_PHAM " +
               "where HOA_DON.MAHD = CHI_TIET_HOA_DON.MAHD and CHI_TIET_HOA_DON.MASP = SAN_PHAM.MASP and month(NGAYXUAT) = '{0}'", cbxT.Text);

                dgvDT.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }

            XulyDgvDT();
            TinhTongTien();
            if(cbxN.Enabled == true)
            {
                chartT();
            }
        }
    }
}
