using DoAnThucTap.DAO;
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
    public partial class FormTongQuat : Form
    {
        string query;
        public FormTongQuat()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void chartT()
        {
            query = string.Format("select SUM(THANHTIEN) as TONGTIEN, DAY(NGAYXUAT) as NGAY from CHI_TIET_HOA_DON, HOA_DON " +
                "where HOA_DON.MAHD = CHI_TIET_HOA_DON.MAHD and MONTH(NGAYXUAT) =  MONTH(GETDATE()) group by DAY(NGAYXUAT)");

            chart1.DataSource = DataProvider.Instance.ExecuteQuery(query);
            chart1.Series["Doanh Thu"].XValueMember = "NGAY";
            chart1.Series["Doanh Thu"].YValueMembers = "TONGTIEN";
            chart1.Titles.Clear();
            chart1.BackColor = Color.FromArgb(200, 216, 228);

            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
        }
        private void chartN()
        {
            query = string.Format("select SUM(THANHTIEN) as TONGTIEN, MONTH(NGAYXUAT) as THANG from CHI_TIET_HOA_DON, HOA_DON " +
                "where HOA_DON.MAHD = CHI_TIET_HOA_DON.MAHD and YEAR(NGAYXUAT) =  YEAR(GETDATE()) group by MONTH(NGAYXUAT)");

            chart2.DataSource = DataProvider.Instance.ExecuteQuery(query);
            chart2.Series["Thang"].XValueMember = "THANG";
            chart2.Series["Thang"].YValueMembers = "TONGTIEN";
            chart2.Titles.Clear();
            chart2.BackColor = Color.FromArgb(200, 216, 228);
            chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            chart2.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart2.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
        }


        private void FormTongQuat_Load(object sender, EventArgs e)
        {
            chartT();
            chartN();

            TongSanPham();
            TongThuNhap();
        }

        private void Time()
        {
            lbTi.Text = DateTime.Now.ToLongTimeString();
            lbDa.Text = DateTime.Now.ToShortDateString();
        }

        private void TongSanPham()
        {
            query = "select sum(SOLUONG) from CHI_TIET_HOA_DON, HOA_DON where MONTH(NGAYXUAT) = MONTH(GETDATE()) and HOA_DON.MAHD = CHI_TIET_HOA_DON.MAHD group by MONTH(NGAYXUAT)";
            if(DataProvider.Instance.ExecuteScalar(query) != null)
            {
                lbSLSP.Text = DataProvider.Instance.ExecuteScalar(query).ToString() + "  SẢN PHẨM";
            }
            else
            {
                lbSLSP.Text = 0.ToString();
            }
        }
        private void TongThuNhap()
        {
            query = "select sum(THANHTIEN) from CHI_TIET_HOA_DON, HOA_DON where MONTH(NGAYXUAT) = MONTH(GETDATE()) and HOA_DON.MAHD = CHI_TIET_HOA_DON.MAHD group by MONTH(NGAYXUAT)";
            if(DataProvider.Instance.ExecuteScalar(query) != null)
            {
                lbTN.Text = string.Format("{0:#,##0.##}", Int32.Parse(DataProvider.Instance.ExecuteScalar(query).ToString())) + "  ĐỒNG";
            }
            else
            {
                lbTN.Text = 0.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time();
        }
    }
}
