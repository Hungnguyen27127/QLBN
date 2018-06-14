namespace QuanLyBenhNhan_PhongKhamDaKhoa.GUI
{
    partial class FCapNhatBN
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
            this.dgvDSBN = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttuoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtkhac = new System.Windows.Forms.RadioButton();
            this.rbtnu = new System.Windows.Forms.RadioButton();
            this.rbtnam = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtKhong = new System.Windows.Forms.RadioButton();
            this.rbtCo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBN)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSBN
            // 
            this.dgvDSBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSBN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSBN.Location = new System.Drawing.Point(4, 19);
            this.dgvDSBN.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSBN.Name = "dgvDSBN";
            this.dgvDSBN.Size = new System.Drawing.Size(628, 444);
            this.dgvDSBN.TabIndex = 0;
            this.dgvDSBN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSBN_CellContentClick);
            this.dgvDSBN.Click += new System.EventHandler(this.dgvDSBN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSBN);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(385, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(636, 467);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Bệnh Nhân";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtsdt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtdiachi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txttuoi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtten);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtma);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 467);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Bệnh Nhân";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(213, 393);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(79, 36);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(44, 393);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(123, 36);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa thông tin";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "BHYT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Số điện thoại:";
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(131, 293);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(237, 22);
            this.txtsdt.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Địa chỉ:";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(131, 209);
            this.txtdiachi.Multiline = true;
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(237, 65);
            this.txtdiachi.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giới tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tuổi:";
            // 
            // txttuoi
            // 
            this.txttuoi.Location = new System.Drawing.Point(131, 120);
            this.txttuoi.Name = "txttuoi";
            this.txttuoi.Size = new System.Drawing.Size(119, 22);
            this.txttuoi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên bệnh nhân:";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(131, 73);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(237, 22);
            this.txtten.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã bệnh nhân:";
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(131, 29);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(119, 22);
            this.txtma.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtkhac);
            this.panel1.Controls.Add(this.rbtnu);
            this.panel1.Controls.Add(this.rbtnam);
            this.panel1.Location = new System.Drawing.Point(131, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 36);
            this.panel1.TabIndex = 21;
            // 
            // rbtkhac
            // 
            this.rbtkhac.AutoSize = true;
            this.rbtkhac.Location = new System.Drawing.Point(165, 8);
            this.rbtkhac.Name = "rbtkhac";
            this.rbtkhac.Size = new System.Drawing.Size(62, 20);
            this.rbtkhac.TabIndex = 23;
            this.rbtkhac.TabStop = true;
            this.rbtkhac.Text = "Khác";
            this.rbtkhac.UseVisualStyleBackColor = true;
            // 
            // rbtnu
            // 
            this.rbtnu.AutoSize = true;
            this.rbtnu.Location = new System.Drawing.Point(91, 8);
            this.rbtnu.Name = "rbtnu";
            this.rbtnu.Size = new System.Drawing.Size(46, 20);
            this.rbtnu.TabIndex = 22;
            this.rbtnu.TabStop = true;
            this.rbtnu.Text = "Nữ";
            this.rbtnu.UseVisualStyleBackColor = true;
            // 
            // rbtnam
            // 
            this.rbtnam.AutoSize = true;
            this.rbtnam.Location = new System.Drawing.Point(9, 8);
            this.rbtnam.Name = "rbtnam";
            this.rbtnam.Size = new System.Drawing.Size(59, 20);
            this.rbtnam.TabIndex = 21;
            this.rbtnam.TabStop = true;
            this.rbtnam.Text = "Nam";
            this.rbtnam.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtKhong);
            this.panel2.Controls.Add(this.rbtCo);
            this.panel2.Location = new System.Drawing.Point(131, 331);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 38);
            this.panel2.TabIndex = 22;
            // 
            // rbtKhong
            // 
            this.rbtKhong.AutoSize = true;
            this.rbtKhong.Location = new System.Drawing.Point(91, 9);
            this.rbtKhong.Name = "rbtKhong";
            this.rbtKhong.Size = new System.Drawing.Size(71, 20);
            this.rbtKhong.TabIndex = 17;
            this.rbtKhong.TabStop = true;
            this.rbtKhong.Text = "Không";
            this.rbtKhong.UseVisualStyleBackColor = true;
            // 
            // rbtCo
            // 
            this.rbtCo.AutoSize = true;
            this.rbtCo.Location = new System.Drawing.Point(9, 9);
            this.rbtCo.Name = "rbtCo";
            this.rbtCo.Size = new System.Drawing.Size(47, 20);
            this.rbtCo.TabIndex = 16;
            this.rbtCo.TabStop = true;
            this.rbtCo.Text = "Có";
            this.rbtCo.UseVisualStyleBackColor = true;
            // 
            // FCapNhatBN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 467);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FCapNhatBN";
            this.Text = "Cập nhật thông tin bệnh nhân";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FCapNhatBN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSBN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttuoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtKhong;
        private System.Windows.Forms.RadioButton rbtCo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtkhac;
        private System.Windows.Forms.RadioButton rbtnu;
        private System.Windows.Forms.RadioButton rbtnam;
    }
}