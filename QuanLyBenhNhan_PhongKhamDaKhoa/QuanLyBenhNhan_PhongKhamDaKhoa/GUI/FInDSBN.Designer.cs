namespace QuanLyBenhNhan_PhongKhamDaKhoa.GUI
{
    partial class FInDSBN
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblTrangthai = new System.Windows.Forms.Label();
            this.btnXuat = new System.Windows.Forms.Button();
            this.dgvDSBN = new System.Windows.Forms.DataGridView();
            this.mABNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tUOIBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIOITINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIACHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bHYTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bENHNHANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bENHNHANBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 337);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(565, 28);
            this.progressBar1.TabIndex = 0;
            // 
            // lblTrangthai
            // 
            this.lblTrangthai.AutoSize = true;
            this.lblTrangthai.Location = new System.Drawing.Point(13, 20);
            this.lblTrangthai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrangthai.Name = "lblTrangthai";
            this.lblTrangthai.Size = new System.Drawing.Size(118, 16);
            this.lblTrangthai.TabIndex = 1;
            this.lblTrangthai.Text = "Đang chạy... 0%";
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(609, 337);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(124, 28);
            this.btnXuat.TabIndex = 2;
            this.btnXuat.Text = "Xuất ra Excel";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // dgvDSBN
            // 
            this.dgvDSBN.AllowUserToAddRows = false;
            this.dgvDSBN.AllowUserToDeleteRows = false;
            this.dgvDSBN.AutoGenerateColumns = false;
            this.dgvDSBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSBN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mABNDataGridViewTextBoxColumn,
            this.tENBNDataGridViewTextBoxColumn,
            this.tUOIBNDataGridViewTextBoxColumn,
            this.gIOITINHDataGridViewTextBoxColumn,
            this.dIACHIDataGridViewTextBoxColumn,
            this.sDTBNDataGridViewTextBoxColumn,
            this.bHYTDataGridViewTextBoxColumn});
            this.dgvDSBN.DataSource = this.bENHNHANBindingSource;
            this.dgvDSBN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSBN.Location = new System.Drawing.Point(3, 18);
            this.dgvDSBN.Name = "dgvDSBN";
            this.dgvDSBN.Size = new System.Drawing.Size(773, 295);
            this.dgvDSBN.TabIndex = 3;
            this.dgvDSBN.UseWaitCursor = true;
            // 
            // mABNDataGridViewTextBoxColumn
            // 
            this.mABNDataGridViewTextBoxColumn.DataPropertyName = "MABN";
            this.mABNDataGridViewTextBoxColumn.HeaderText = "Mã bệnh nhân";
            this.mABNDataGridViewTextBoxColumn.Name = "mABNDataGridViewTextBoxColumn";
            // 
            // tENBNDataGridViewTextBoxColumn
            // 
            this.tENBNDataGridViewTextBoxColumn.DataPropertyName = "TENBN";
            this.tENBNDataGridViewTextBoxColumn.HeaderText = "Tên bệnh nhân";
            this.tENBNDataGridViewTextBoxColumn.Name = "tENBNDataGridViewTextBoxColumn";
            // 
            // tUOIBNDataGridViewTextBoxColumn
            // 
            this.tUOIBNDataGridViewTextBoxColumn.DataPropertyName = "TUOIBN";
            this.tUOIBNDataGridViewTextBoxColumn.HeaderText = "Tuổi";
            this.tUOIBNDataGridViewTextBoxColumn.Name = "tUOIBNDataGridViewTextBoxColumn";
            // 
            // gIOITINHDataGridViewTextBoxColumn
            // 
            this.gIOITINHDataGridViewTextBoxColumn.DataPropertyName = "GIOITINH";
            this.gIOITINHDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            this.gIOITINHDataGridViewTextBoxColumn.Name = "gIOITINHDataGridViewTextBoxColumn";
            // 
            // dIACHIDataGridViewTextBoxColumn
            // 
            this.dIACHIDataGridViewTextBoxColumn.DataPropertyName = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.dIACHIDataGridViewTextBoxColumn.Name = "dIACHIDataGridViewTextBoxColumn";
            // 
            // sDTBNDataGridViewTextBoxColumn
            // 
            this.sDTBNDataGridViewTextBoxColumn.DataPropertyName = "SDTBN";
            this.sDTBNDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.sDTBNDataGridViewTextBoxColumn.Name = "sDTBNDataGridViewTextBoxColumn";
            // 
            // bHYTDataGridViewTextBoxColumn
            // 
            this.bHYTDataGridViewTextBoxColumn.DataPropertyName = "BHYT";
            this.bHYTDataGridViewTextBoxColumn.HeaderText = "BHYT";
            this.bHYTDataGridViewTextBoxColumn.Name = "bHYTDataGridViewTextBoxColumn";
            // 
            // bENHNHANBindingSource
            // 
            this.bENHNHANBindingSource.DataSource = typeof(QuanLyBenhNhan_PhongKhamDaKhoa.BENHNHAN);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSBN);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 316);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Bệnh Nhân";
            this.groupBox1.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTrangthai);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 381);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(779, 45);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // FInDanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 426);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.progressBar1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FInDanhSach";
            this.Text = "FInDanhSach";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FInDanhSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bENHNHANBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblTrangthai;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.DataGridView dgvDSBN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mABNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tUOIBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIOITINHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIACHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bHYTDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bENHNHANBindingSource;
    }
}