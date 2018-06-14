namespace QuanLyBenhNhan_PhongKhamDaKhoa.GUI
{
    partial class FDonThuoc
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
            this.grbdonthuoc = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDonthuoc = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new QuanLyBenhNhan_PhongKhamDaKhoa.DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxthuoc = new System.Windows.Forms.ComboBox();
            this.cbxbacsy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmadonthuoc = new System.Windows.Forms.TextBox();
            this.txttienthuoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtlieudung = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.cbxbenhnhan = new System.Windows.Forms.ComboBox();
            this.lblmabs = new System.Windows.Forms.Label();
            this.lblmathuoc = new System.Windows.Forms.Label();
            this.lblmabn = new System.Windows.Forms.Label();
            this.grbdonthuoc.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonthuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbdonthuoc
            // 
            this.grbdonthuoc.Controls.Add(this.lblmabn);
            this.grbdonthuoc.Controls.Add(this.lblmathuoc);
            this.grbdonthuoc.Controls.Add(this.lblmabs);
            this.grbdonthuoc.Controls.Add(this.cbxbenhnhan);
            this.grbdonthuoc.Controls.Add(this.txtlieudung);
            this.grbdonthuoc.Controls.Add(this.label7);
            this.grbdonthuoc.Controls.Add(this.label6);
            this.grbdonthuoc.Controls.Add(this.txttienthuoc);
            this.grbdonthuoc.Controls.Add(this.label5);
            this.grbdonthuoc.Controls.Add(this.label4);
            this.grbdonthuoc.Controls.Add(this.cbxbacsy);
            this.grbdonthuoc.Controls.Add(this.label3);
            this.grbdonthuoc.Controls.Add(this.cbxthuoc);
            this.grbdonthuoc.Controls.Add(this.label2);
            this.grbdonthuoc.Controls.Add(this.txtmadonthuoc);
            this.grbdonthuoc.Controls.Add(this.label1);
            this.grbdonthuoc.Location = new System.Drawing.Point(0, 0);
            this.grbdonthuoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbdonthuoc.Name = "grbdonthuoc";
            this.grbdonthuoc.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbdonthuoc.Size = new System.Drawing.Size(472, 385);
            this.grbdonthuoc.TabIndex = 0;
            this.grbdonthuoc.TabStop = false;
            this.grbdonthuoc.Text = "Thêm mới đơn thuốc";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDonthuoc);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(417, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 476);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách đơn thuốc";
            // 
            // dgvDonthuoc
            // 
            this.dgvDonthuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonthuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDonthuoc.Location = new System.Drawing.Point(3, 18);
            this.dgvDonthuoc.Name = "dgvDonthuoc";
            this.dgvDonthuoc.Size = new System.Drawing.Size(518, 455);
            this.dgvDonthuoc.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đơn thuốc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên thuốc:";
            // 
            // cbxthuoc
            // 
            this.cbxthuoc.FormattingEnabled = true;
            this.cbxthuoc.Location = new System.Drawing.Point(150, 127);
            this.cbxthuoc.Name = "cbxthuoc";
            this.cbxthuoc.Size = new System.Drawing.Size(181, 24);
            this.cbxthuoc.TabIndex = 3;
            this.cbxthuoc.TextChanged += new System.EventHandler(this.cbxthuoc_TextChanged);
            // 
            // cbxbacsy
            // 
            this.cbxbacsy.FormattingEnabled = true;
            this.cbxbacsy.Location = new System.Drawing.Point(150, 81);
            this.cbxbacsy.Name = "cbxbacsy";
            this.cbxbacsy.Size = new System.Drawing.Size(181, 24);
            this.cbxbacsy.TabIndex = 5;
            this.cbxbacsy.TextChanged += new System.EventHandler(this.cbxbacsy_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên bác sỹ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên bệnh nhân: ";
            // 
            // txtmadonthuoc
            // 
            this.txtmadonthuoc.Enabled = false;
            this.txtmadonthuoc.Location = new System.Drawing.Point(150, 34);
            this.txtmadonthuoc.Name = "txtmadonthuoc";
            this.txtmadonthuoc.Size = new System.Drawing.Size(144, 22);
            this.txtmadonthuoc.TabIndex = 1;
            // 
            // txttienthuoc
            // 
            this.txttienthuoc.Enabled = false;
            this.txttienthuoc.Location = new System.Drawing.Point(150, 218);
            this.txttienthuoc.Name = "txttienthuoc";
            this.txttienthuoc.Size = new System.Drawing.Size(161, 22);
            this.txttienthuoc.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tiền thuốc:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "(nghìn đồng)";
            // 
            // txtlieudung
            // 
            this.txtlieudung.Location = new System.Drawing.Point(150, 262);
            this.txtlieudung.Multiline = true;
            this.txtlieudung.Name = "txtlieudung";
            this.txtlieudung.Size = new System.Drawing.Size(261, 86);
            this.txtlieudung.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Liều dùng";
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(261, 414);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(101, 38);
            this.btnluu.TabIndex = 17;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(71, 414);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(122, 38);
            this.btnthem.TabIndex = 16;
            this.btnthem.Text = "Thêm mới";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // cbxbenhnhan
            // 
            this.cbxbenhnhan.FormattingEnabled = true;
            this.cbxbenhnhan.Location = new System.Drawing.Point(150, 173);
            this.cbxbenhnhan.Name = "cbxbenhnhan";
            this.cbxbenhnhan.Size = new System.Drawing.Size(181, 24);
            this.cbxbenhnhan.TabIndex = 14;
            this.cbxbenhnhan.TextChanged += new System.EventHandler(this.cbxbenhnhan_TextChanged);
            // 
            // lblmabs
            // 
            this.lblmabs.AutoSize = true;
            this.lblmabs.Location = new System.Drawing.Point(354, 84);
            this.lblmabs.Name = "lblmabs";
            this.lblmabs.Size = new System.Drawing.Size(61, 16);
            this.lblmabs.TabIndex = 15;
            this.lblmabs.Text = "Mã BS: ";
            // 
            // lblmathuoc
            // 
            this.lblmathuoc.AutoSize = true;
            this.lblmathuoc.Location = new System.Drawing.Point(354, 130);
            this.lblmathuoc.Name = "lblmathuoc";
            this.lblmathuoc.Size = new System.Drawing.Size(78, 16);
            this.lblmathuoc.TabIndex = 16;
            this.lblmathuoc.Text = "Mã thuốc: ";
            // 
            // lblmabn
            // 
            this.lblmabn.AutoSize = true;
            this.lblmabn.Location = new System.Drawing.Point(354, 176);
            this.lblmabn.Name = "lblmabn";
            this.lblmabn.Size = new System.Drawing.Size(66, 16);
            this.lblmabn.TabIndex = 17;
            this.lblmabn.Text = "Mã BN:  ";
            // 
            // FDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 476);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbdonthuoc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FDonThuoc";
            this.Text = "Đơn Thuốc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FDonThuoc_Load);
            this.grbdonthuoc.ResumeLayout(false);
            this.grbdonthuoc.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonthuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbdonthuoc;
        private System.Windows.Forms.GroupBox groupBox2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.DataGridView dgvDonthuoc;
        private System.Windows.Forms.TextBox txtlieudung;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttienthuoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxbacsy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxthuoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmadonthuoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.ComboBox cbxbenhnhan;
        private System.Windows.Forms.Label lblmabn;
        private System.Windows.Forms.Label lblmathuoc;
        private System.Windows.Forms.Label lblmabs;
    }
}