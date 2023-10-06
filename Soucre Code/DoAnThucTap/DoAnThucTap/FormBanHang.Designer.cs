
namespace DoAnThucTap
{
    partial class FormBanHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvBH = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXSP = new System.Windows.Forms.Button();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTT = new System.Windows.Forms.Button();
            this.txtMSP = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTSL = new System.Windows.Forms.Button();
            this.cmbCR = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCMR = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMBH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBH)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBH
            // 
            this.dgvBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBH.Location = new System.Drawing.Point(12, 458);
            this.dgvBH.Name = "dgvBH";
            this.dgvBH.RowHeadersWidth = 51;
            this.dgvBH.Size = new System.Drawing.Size(1423, 237);
            this.dgvBH.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Bán Hàng:";
            // 
            // btnXSP
            // 
            this.btnXSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(171)))), ((int)(((byte)(152)))));
            this.btnXSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXSP.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXSP.ForeColor = System.Drawing.Color.White;
            this.btnXSP.Location = new System.Drawing.Point(388, 301);
            this.btnXSP.Name = "btnXSP";
            this.btnXSP.Size = new System.Drawing.Size(259, 46);
            this.btnXSP.TabIndex = 11;
            this.btnXSP.Text = "XÓA SẢN PHẨM";
            this.btnXSP.UseVisualStyleBackColor = false;
            this.btnXSP.Click += new System.EventHandler(this.btnXSP_Click);
            // 
            // txtTT
            // 
            this.txtTT.BackColor = System.Drawing.Color.White;
            this.txtTT.Enabled = false;
            this.txtTT.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTT.ForeColor = System.Drawing.Color.Red;
            this.txtTT.Location = new System.Drawing.Point(1038, 709);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(397, 39);
            this.txtTT.TabIndex = 13;
            this.txtTT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(885, 712);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 34);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tổng Tiền:";
            // 
            // btnTT
            // 
            this.btnTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(171)))), ((int)(((byte)(152)))));
            this.btnTT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTT.ForeColor = System.Drawing.Color.White;
            this.btnTT.Location = new System.Drawing.Point(12, 703);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(259, 45);
            this.btnTT.TabIndex = 15;
            this.btnTT.Text = "THANH TOÁN";
            this.btnTT.UseVisualStyleBackColor = false;
            this.btnTT.Click += new System.EventHandler(this.btnTT_Click);
            // 
            // txtMSP
            // 
            this.txtMSP.BackColor = System.Drawing.Color.Silver;
            this.txtMSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMSP.Enabled = false;
            this.txtMSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtMSP.Location = new System.Drawing.Point(553, 93);
            this.txtMSP.Name = "txtMSP";
            this.txtMSP.Size = new System.Drawing.Size(122, 30);
            this.txtMSP.TabIndex = 16;
            this.txtMSP.TextChanged += new System.EventHandler(this.txtMSP_TextChanged);
            // 
            // txtSL
            // 
            this.txtSL.BackColor = System.Drawing.Color.White;
            this.txtSL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.ForeColor = System.Drawing.Color.Black;
            this.txtSL.Location = new System.Drawing.Point(183, 182);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(122, 30);
            this.txtSL.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(383, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 26);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mã Sản Phẩm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 26);
            this.label4.TabIndex = 19;
            this.label4.Text = "Số Lượng:";
            // 
            // btnTSL
            // 
            this.btnTSL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(171)))), ((int)(((byte)(152)))));
            this.btnTSL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTSL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTSL.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTSL.ForeColor = System.Drawing.Color.White;
            this.btnTSL.Location = new System.Drawing.Point(46, 302);
            this.btnTSL.Name = "btnTSL";
            this.btnTSL.Size = new System.Drawing.Size(259, 45);
            this.btnTSL.TabIndex = 20;
            this.btnTSL.Text = "THÊM SỐ LƯỢNG";
            this.btnTSL.UseVisualStyleBackColor = false;
            this.btnTSL.Click += new System.EventHandler(this.btnTSL_Click);
            // 
            // cmbCR
            // 
            this.cmbCR.BackColor = System.Drawing.Color.White;
            this.cmbCR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCR.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCR.ForeColor = System.Drawing.Color.Black;
            this.cmbCR.FormattingEnabled = true;
            this.cmbCR.Location = new System.Drawing.Point(793, 9);
            this.cmbCR.Name = "cmbCR";
            this.cmbCR.Size = new System.Drawing.Size(453, 30);
            this.cmbCR.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(693, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 26);
            this.label5.TabIndex = 22;
            this.label5.Text = "Camera";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnCMR);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtMBH);
            this.panel1.Controls.Add(this.btnTSL);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbCR);
            this.panel1.Controls.Add(this.btnXSP);
            this.panel1.Controls.Add(this.txtMSP);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1493, 452);
            this.panel1.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(1, 48);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(699, 5);
            this.panel4.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(1, 250);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(699, 5);
            this.panel3.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 35);
            this.label6.TabIndex = 31;
            this.label6.Text = "Bán Hàng";
            // 
            // btnCMR
            // 
            this.btnCMR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(171)))), ((int)(((byte)(152)))));
            this.btnCMR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCMR.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCMR.ForeColor = System.Drawing.Color.White;
            this.btnCMR.Location = new System.Drawing.Point(1252, 7);
            this.btnCMR.Name = "btnCMR";
            this.btnCMR.Size = new System.Drawing.Size(183, 37);
            this.btnCMR.TabIndex = 26;
            this.btnCMR.Text = "TẮT CAMERA";
            this.btnCMR.UseVisualStyleBackColor = false;
            this.btnCMR.Click += new System.EventHandler(this.btnCMR_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(698, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(737, 404);
            this.panel2.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(19, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(699, 368);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // txtMBH
            // 
            this.txtMBH.BackColor = System.Drawing.Color.Silver;
            this.txtMBH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMBH.Enabled = false;
            this.txtMBH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMBH.ForeColor = System.Drawing.Color.White;
            this.txtMBH.Location = new System.Drawing.Point(183, 93);
            this.txtMBH.Name = "txtMBH";
            this.txtMBH.Size = new System.Drawing.Size(122, 30);
            this.txtMBH.TabIndex = 25;
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1493, 777);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTT);
            this.Controls.Add(this.dgvBH);
            this.Controls.Add(this.btnTT);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Name = "FormBanHang";
            this.Text = "BÁN HÀNG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBanHang_FormClosing);
            this.Load += new System.EventHandler(this.FormBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXSP;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTT;
        private System.Windows.Forms.TextBox txtMSP;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTSL;
        private System.Windows.Forms.ComboBox cmbCR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMBH;
        private System.Windows.Forms.Button btnCMR;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}