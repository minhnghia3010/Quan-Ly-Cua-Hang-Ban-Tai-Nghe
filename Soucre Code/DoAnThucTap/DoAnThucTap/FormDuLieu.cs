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
    public partial class FormDuLieu : Form
    {
        string query;

        public FormDuLieu()
        {
            InitializeComponent();
        }

        private void FormDuLieu_Load(object sender, EventArgs e)
        {
            LoadSP();
            LoadTH();
            LoadGG();
            Null();
            LoaCbxCL();
            LoadCbxM();
            LoadCbxS();
        }

        private void XulyDgvSP()
        {
            dgvSP.BorderStyle = BorderStyle.None;
            dgvSP.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSP.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            dgvSP.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 15);
            dgvSP.EnableHeadersVisualStyles = false;
            dgvSP.BorderStyle = BorderStyle.None;

            dgvSP.BackgroundColor = Color.FromArgb(255, 250, 250);
            dgvSP.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSP.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);
            dgvSP.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 250, 250);
            dgvSP.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 250, 250);
            dgvSP.DefaultCellStyle.BackColor = Color.FromArgb(255, 250, 250);
            dgvSP.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 250, 250);
            dgvSP.DefaultCellStyle.SelectionBackColor = Color.FromArgb(205, 92, 92);
            dgvSP.DefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);

            dgvSP.Columns[0].HeaderText = "Mã Sản Phẩm";
            dgvSP.Columns[1].HeaderText = "Tên Sản Phẩm";
            dgvSP.Columns[1].Width = 300;
            dgvSP.Columns[2].HeaderText = "Màu";
            dgvSP.Columns[3].HeaderText = "Loại Tai Nghe";
            dgvSP.Columns[4].HeaderText = "Thời Lượng Pin";
            dgvSP.Columns[5].HeaderText = "Giá";
            dgvSP.Columns[6].Visible = false;
            dgvSP.Columns[7].Visible = false;
            dgvSP.Columns[8].HeaderText = "Mã Thương Hiệu";
            dgvSP.Columns[9].HeaderText = "Mã Giảm Giá";
        }

        private void LoadSP()
        {
            query = "select * from SAN_PHAM";

            dgvSP.DataSource = DataProvider.Instance.ExecuteQuery(query);
            XulyDgvSP();
            //Load textbox sản phẩm
            txtMSP.DataBindings.Clear();
            txtMSP.DataBindings.Add("Text", dgvSP.DataSource, "MASP");
            txtTSP.DataBindings.Clear();
            txtTSP.DataBindings.Add("Text", dgvSP.DataSource, "TENSP");
            txtTH.DataBindings.Clear();
            txtTH.DataBindings.Add("Text", dgvSP.DataSource, "MATH");
            txtGG.DataBindings.Clear();
            txtGG.DataBindings.Add("Text", dgvSP.DataSource, "MAGG");
            txtG.DataBindings.Clear();
            txtG.DataBindings.Add("Text", dgvSP.DataSource, "GIA");
        }

        private void XulyDgvTH()
        {
            dgvTH.BorderStyle = BorderStyle.None;
            dgvTH.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvTH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTH.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            dgvTH.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 15);
            dgvTH.EnableHeadersVisualStyles = false;
            dgvTH.BorderStyle = BorderStyle.None;

            dgvTH.BackgroundColor = Color.FromArgb(255, 250, 250);
            dgvTH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTH.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);
            dgvTH.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 250, 250);
            dgvTH.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 250, 250);
            dgvTH.DefaultCellStyle.BackColor = Color.FromArgb(255, 250, 250);
            dgvTH.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 250, 250);
            dgvTH.DefaultCellStyle.SelectionBackColor = Color.FromArgb(205, 92, 92);
            dgvTH.DefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);

            dgvTH.Columns[0].HeaderText = "Mã Thương Hiệu";
            dgvTH.Columns[1].HeaderText = "Tên Thương Hiệu";
        }

        private void LoadTH()
        {
            query = "select * from THUONG_HIEU";

            dgvTH.DataSource = DataProvider.Instance.ExecuteQuery(query);
            XulyDgvTH();
            //Load textbox thương hiệu
            txtMTH.DataBindings.Clear();
            txtMTH.DataBindings.Add("Text", dgvTH.DataSource, "MATH");
            txtTTH.DataBindings.Clear();
            txtTTH.DataBindings.Add("Text", dgvTH.DataSource, "TENTH");
        }

        private void XulyDgvGG()
        {
            dgvGG.BorderStyle = BorderStyle.None;
            dgvGG.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvGG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGG.EnableHeadersVisualStyles = false;
            dgvGG.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            dgvGG.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 15);
            dgvGG.EnableHeadersVisualStyles = false;
            dgvGG.BorderStyle = BorderStyle.None;

            dgvGG.BackgroundColor = Color.FromArgb(255, 250, 250);
            dgvGG.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvGG.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);
            dgvGG.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 250, 250);
            dgvGG.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 250, 250);
            dgvGG.DefaultCellStyle.BackColor = Color.FromArgb(255, 250, 250);
            dgvGG.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 250, 250);
            dgvGG.DefaultCellStyle.SelectionBackColor = Color.FromArgb(205, 92, 92);
            dgvGG.DefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);

            dgvGG.Columns[0].HeaderText = "Mã Giảm Giá";
            dgvGG.Columns[1].HeaderText = "Mã Giảm Giá (%)";
        }

        private void LoadGG()
        {
            query = "select * from GIAM_GIA";

            dgvGG.DataSource = DataProvider.Instance.ExecuteQuery(query);
            XulyDgvGG();
            //Load textbox giảm giá
            txtMGG.DataBindings.Clear();
            txtMGG.DataBindings.Add("Text", dgvGG.DataSource, "MAGG");
            txtSOGG.DataBindings.Clear();
            txtSOGG.DataBindings.Add("Text", dgvGG.DataSource, "SOGG");
        }

        private void btnTSP_Click(object sender, EventArgs e)
        {
            query = string.Format("insert into SAN_PHAM values(N'{0}',N'{1}',N'{2}','{3}',{4},{5},N'{6}',{7},{8})",
                txtTSP.Text, cbxM.Text, cbxS.Text, cbxCL.Text, Int32.Parse(txtG.Text), 0, "Thiếu", Int32.Parse(txtTH.Text), Int32.Parse(txtGG.Text));

            try
            {
                DataProvider.Instance.ExecuteNonQuery(query);
                MessageBox.Show("Thêm Sản Phẩm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormDuLieu_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Thêm Sản Phẩm Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXSP_Click(object sender, EventArgs e)
        {
            query = string.Format("delete from SAN_PHAM where MASP = {0}", Int32.Parse(txtMSP.Text));

            try
            {
                DataProvider.Instance.ExecuteNonQuery(query);
                MessageBox.Show("Xóa Sản Phẩm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormDuLieu_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Xóa Sản Phẩm Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUSP_Click(object sender, EventArgs e)
        {
            query = string.Format("update SAN_PHAM set TENSP = '{0}', MAU = '{1}', LOAITN = '{2}', THOILUONGPIN = '{3}', GIA = {4}, MATH = {5}, MAGG = {6} where MASP = {7}",
                txtTSP.Text, cbxM.Text, cbxS.Text, cbxCL.Text, txtG.Text, txtTH.Text, txtGG.Text, Int32.Parse(txtMSP.Text));

            try
            {
                DataProvider.Instance.ExecuteNonQuery(query);
                MessageBox.Show("Sửa Sản Phẩm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormDuLieu_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Sửa Sản Phẩm Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTTH_Click(object sender, EventArgs e)
        {
            query = string.Format("insert into THUONG_HIEU values('{0}')", txtTTH.Text);

            try
            {
                DataProvider.Instance.ExecuteNonQuery(query);
                MessageBox.Show("Thêm Thương Hiệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormDuLieu_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Thêm Thương Hiệu Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXTH_Click(object sender, EventArgs e)
        {
            query = string.Format("delete from THUONG_HIEU where MATH = {0}", Int32.Parse(txtMTH.Text));

            try
            {
                DataProvider.Instance.ExecuteNonQuery(query);
                MessageBox.Show("Xóa Thương Hiệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormDuLieu_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Xóa Thương Hiệu Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTGG_Click(object sender, EventArgs e)
        {
            query = string.Format("insert into GIAM_GIA values('{0}')", txtSOGG.Text);

            try
            {
                DataProvider.Instance.ExecuteNonQuery(query);
                MessageBox.Show("Thêm Giảm Giá Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormDuLieu_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Thêm Giảm Giá Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXGG_Click(object sender, EventArgs e)
        {
            query = string.Format("delete from GIAM_GIA where MAGG = {0}", Int32.Parse(txtMGG.Text));

            try
            {
                DataProvider.Instance.ExecuteNonQuery(query);
                MessageBox.Show("Xóa Giảm Giá Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormDuLieu_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Xóa Giảm Giá Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUTH_Click(object sender, EventArgs e)
        {
            query = string.Format("update THUONG_HIEU set TENTH = '{0}' where MATH = {1} ",
               txtTTH.Text, Int16.Parse(txtMTH.Text));

            try
            {
                DataProvider.Instance.ExecuteNonQuery(query);
                MessageBox.Show("Sửa Thương Hiệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormDuLieu_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Sửa Thương Hiệu Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUGG_Click(object sender, EventArgs e)
        {
            query = string.Format("update GIAM_GIA set SOGG = '{0}' where MAGG = {1} ",
               txtSOGG.Text, Int16.Parse(txtMGG.Text));

            try
            {
                DataProvider.Instance.ExecuteNonQuery(query);
                MessageBox.Show("Sửa Giảm Giá Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormDuLieu_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Sửa Giảm Giá Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Null()
        {
            cbxM.SelectedIndex = -1;
            cbxCL.SelectedIndex = -1;
            cbxS.SelectedIndex = -1;
            txtG.Text = "";
            txtGG.Text = "";
            txtTH.Text = "";
            txtSOGG.Text = "";
            txtTTH.Text = "";
            txtMSP.Text = "";
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            query = string.Format("select * from SAN_PHAM where THOILUONGPIN = '{0}' or LOAITN = '{1}' or MAU = '{2}'",
                cbxCL.Text, cbxS.Text, cbxM.Text);

            dgvSP.DataSource = DataProvider.Instance.ExecuteQuery(query);

            if (cbxCL.Text == "" && cbxM.Text == "" && cbxS.Text == "")
            {
                LoadSP();
            }
        }

        private void LoadCbxM()
        {
            query = "select distinct MAU from SAN_PHAM";

            cbxM.DataSource = DataProvider.Instance.ExecuteQuery(query);
            cbxM.DisplayMember = "MAU";
        }

        private void LoadCbxS()
        {
            query = "select distinct LOAITN from SAN_PHAM";

            cbxS.DataSource = DataProvider.Instance.ExecuteQuery(query);
            cbxS.DisplayMember = "LOAITN";
        }

        private void LoaCbxCL()
        {
            query = "select distinct THOILUONGPIN from SAN_PHAM";

            cbxCL.DataSource = DataProvider.Instance.ExecuteQuery(query);
            cbxCL.DisplayMember = "THOILUONGPIN";
        }
    }
}
