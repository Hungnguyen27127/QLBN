namespace QuanLyBenhNhan_PhongKhamDaKhoa.GUI
{
    partial class FTimKiemBN
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxTimkiem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvBN = new System.Windows.Forms.DataGridView();
            this.mABNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tUOIBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIOITINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIACHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bHYTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bENHNHANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bENHNHANBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.txtTimkiem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxTimkiem);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(775, 532);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dữ liệu cần tìm kiếm";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbxTimkiem
            // 
            this.cbxTimkiem.FormattingEnabled = true;
            this.cbxTimkiem.Items.AddRange(new object[] {
            "Mã bệnh nhân",
            "Tên bệnh nhân",
            "Tuổi",
            "Giới tính nam",
            "Giới tính nữ",
            "Giới tính khác",
            "Địa chỉ",
            "Số điện thoại",
            "Có thẻ BHYT",
            "Không có thẻ BHYT"});
            this.cbxTimkiem.Location = new System.Drawing.Point(236, 44);
            this.cbxTimkiem.Name = "cbxTimkiem";
            this.cbxTimkiem.Size = new System.Drawing.Size(214, 24);
            this.cbxTimkiem.TabIndex = 0;
            this.cbxTimkiem.SelectedIndexChanged += new System.EventHandler(this.cbxTimkiem_SelectedIndexChanged);
            this.cbxTimkiem.TextChanged += new System.EventHandler(this.cbxTimkiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm theo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập nội dung tìm kiếm: ";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(236, 99);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(346, 22);
            this.txtTimkiem.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.dgvBN);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 356);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách bệnh nhân";
            // 
            // dgvBN
            // 
            this.dgvBN.AutoGenerateColumns = false;
            this.dgvBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mABNDataGridViewTextBoxColumn,
            this.tENBNDataGridViewTextBoxColumn,
            this.tUOIBNDataGridViewTextBoxColumn,
            this.gIOITINHDataGridViewTextBoxColumn,
            this.dIACHIDataGridViewTextBoxColumn,
            this.sDTBNDataGridViewTextBoxColumn,
            this.bHYTDataGridViewTextBoxColumn});
            this.dgvBN.DataSource = this.bENHNHANBindingSource;
            this.dgvBN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBN.Location = new System.Drawing.Point(3, 18);
            this.dgvBN.Name = "dgvBN";
            this.dgvBN.Size = new System.Drawing.Size(769, 335);
            this.dgvBN.TabIndex = 0;
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
            // FTimKiemBN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 532);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FTimKiemBN";
            this.Text = "Tìm Kiếm Bệnh Nhân";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FTimKiemBN_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bENHNHANBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTimkiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvBN;
        private System.Windows.Forms.BindingSource bENHNHANBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn mABNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tUOIBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIOITINHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIACHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bHYTDataGridViewTextBoxColumn;
    }
}