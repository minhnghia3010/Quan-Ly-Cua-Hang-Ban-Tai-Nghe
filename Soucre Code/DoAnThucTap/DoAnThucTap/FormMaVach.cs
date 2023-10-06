using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing;
using System.Data.SqlClient;
using DoAnThucTap.DAO;

namespace DoAnThucTap
{
    public partial class FormMaVach : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice VideoCaptureDevice;

        string query;

        public FormMaVach()
        {
            InitializeComponent();
        }

        private void btnQR_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator qRCodeGenerator = new QRCoder.QRCodeGenerator();
            var data = qRCodeGenerator.CreateQrCode(cbxQR.Text, QRCoder.QRCodeGenerator.ECCLevel.M);
            var code = new QRCoder.QRCode(data);
            pictureBox3.Image = code.GetGraphic(6);
        }

        private void btnIMV_Click(object sender, EventArgs e)
        {
            BarcodeWriter barcodeWriter = new BarcodeWriter()
            {
                Format = BarcodeFormat.CODE_128,
                Options =
                {
                    Width = 200,
                    Height = 100
                }
            };
            pictureBox1.Image = barcodeWriter.Write(cbxMV.Text);
        }

        private void LoadCbx()
        {
            query = "select * from SAN_PHAM";
            string query1 = "select * from NHAN_VIEN";

            cbxMV.DataSource = DataProvider.Instance.ExecuteQuery(query);
            cbxMV.DisplayMember = "MASP";
            cbxQR.DataSource = DataProvider.Instance.ExecuteQuery(query1);
            cbxQR.DisplayMember = "MANV";
        }

        private void FormMaVach_Load(object sender, EventArgs e)
        {
            QuetMa();
        }

        private void QuetMa()
        {
            LoadCbx();
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cbxCMR.Items.Add(filterInfo.Name);
            cbxCMR.SelectedIndex = 0;

            VideoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbxCMR.SelectedIndex].MonikerString);
            VideoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            VideoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                textBox3.Invoke(new MethodInvoker(delegate ()
                {
                    textBox3.Text = result.ToString();
                }));
            }
            pictureBox2.Image = bitmap;
        }

        private void FormMaVach_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (VideoCaptureDevice != null)
            {
                if (VideoCaptureDevice.IsRunning)
                    VideoCaptureDevice.Stop();
            }
        }

        private void btnTCR_Click(object sender, EventArgs e)
        {
            if (VideoCaptureDevice != null)
            {
                if (VideoCaptureDevice.IsRunning)
                    VideoCaptureDevice.Stop();
            }
        }

        private void cbxCMR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
