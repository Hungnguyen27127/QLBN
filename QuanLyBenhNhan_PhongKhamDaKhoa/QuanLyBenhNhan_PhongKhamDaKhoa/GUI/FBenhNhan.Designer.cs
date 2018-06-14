namespace QuanLyBenhNhan_PhongKhamDaKhoa.GUI
{
    partial class FBenhNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBenhNhan));
            System.Windows.Forms.Label sDTBNLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label gIOITINHLabel;
            System.Windows.Forms.Label tUOIBNLabel;
            System.Windows.Forms.Label tENBNLabel;
            System.Windows.Forms.Label mABNLabel;
            System.Windows.Forms.Label bHYTLabel;
            this.dataSet1 = new QuanLyBenhNhan_PhongKhamDaKhoa.DataSet1();
            this.bENHNHANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bENHNHANTableAdapter = new QuanLyBenhNhan_PhongKhamDaKhoa.DataSet1TableAdapters.BENHNHANTableAdapter();
            this.tableAdapterManager = new QuanLyBenhNhan_PhongKhamDaKhoa.DataSet1TableAdapters.TableAdapterManager();
            this.bENHNHANBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bENHNHANBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.grbBenhnhan = new System.Windows.Forms.GroupBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.cbbGioitinh = new System.Windows.Forms.ComboBox();
            this.txtTuoi = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.bENHNHANDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bHYTComboBox = new System.Windows.Forms.ComboBox();
            sDTBNLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            gIOITINHLabel = new System.Windows.Forms.Label();
            tUOIBNLabel = new System.Windows.Forms.Label();
            tENBNLabel = new System.Windows.Forms.Label();
            mABNLabel = new System.Windows.Forms.Label();
            bHYTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bENHNHANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bENHNHANBindingNavigator)).BeginInit();
            this.bENHNHANBindingNavigator.SuspendLayout();
            this.grbBenhnhan.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bENHNHANDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bENHNHANBindingSource
            // 
            this.bENHNHANBindingSource.DataMember = "BENHNHAN";
            this.bENHNHANBindingSource.DataSource = this.dataSet1;
            // 
            // bENHNHANTableAdapter
            // 
            this.bENHNHANTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BENHNHANTableAdapter = this.bENHNHANTableAdapter;
            this.tableAdapterManager.UpdateOrder = QuanLyBenhNhan_PhongKhamDaKhoa.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bENHNHANBindingNavigator
            // 
            this.bENHNHANBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bENHNHANBindingNavigator.BindingSource = this.bENHNHANBindingSource;
            this.bENHNHANBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bENHNHANBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bENHNHANBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bENHNHANBindingNavigatorSaveItem});
            this.bENHNHANBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bENHNHANBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bENHNHANBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bENHNHANBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bENHNHANBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bENHNHANBindingNavigator.Name = "bENHNHANBindingNavigator";
            this.bENHNHANBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bENHNHANBindingNavigator.Size = new System.Drawing.Size(881, 25);
            this.bENHNHANBindingNavigator.TabIndex = 3;
            this.bENHNHANBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bENHNHANBindingNavigatorSaveItem
            // 
            this.bENHNHANBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bENHNHANBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bENHNHANBindingNavigatorSaveItem.Image")));
            this.bENHNHANBindingNavigatorSaveItem.Name = "bENHNHANBindingNavigatorSaveItem";
            this.bENHNHANBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bENHNHANBindingNavigatorSaveItem.Text = "Save Data";
            this.bENHNHANBindingNavigatorSaveItem.Click += new System.EventHandler(this.bENHNHANBindingNavigatorSaveItem_Click_1);
            // 
            // grbBenhnhan
            // 
            this.grbBenhnhan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grbBenhnhan.Controls.Add(bHYTLabel);
            this.grbBenhnhan.Controls.Add(this.bHYTComboBox);
            this.grbBenhnhan.Controls.Add(sDTBNLabel);
            this.grbBenhnhan.Controls.Add(this.txtSdt);
            this.grbBenhnhan.Controls.Add(dIACHILabel);
            this.grbBenhnhan.Controls.Add(this.txtDiachi);
            this.grbBenhnhan.Controls.Add(gIOITINHLabel);
            this.grbBenhnhan.Controls.Add(this.cbbGioitinh);
            this.grbBenhnhan.Controls.Add(tUOIBNLabel);
            this.grbBenhnhan.Controls.Add(this.txtTuoi);
            this.grbBenhnhan.Controls.Add(tENBNLabel);
            this.grbBenhnhan.Controls.Add(this.txtTen);
            this.grbBenhnhan.Controls.Add(mABNLabel);
            this.grbBenhnhan.Controls.Add(this.txtMa);
            this.grbBenhnhan.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbBenhnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBenhnhan.Location = new System.Drawing.Point(0, 25);
            this.grbBenhnhan.Name = "grbBenhnhan";
            this.grbBenhnhan.Size = new System.Drawing.Size(381, 437);
            this.grbBenhnhan.TabIndex = 4;
            this.grbBenhnhan.TabStop = false;
            this.grbBenhnhan.Text = "Thông Tin Bệnh Nhân";
            // 
            // sDTBNLabel
            // 
            sDTBNLabel.AutoSize = true;
            sDTBNLabel.Location = new System.Drawing.Point(6, 305);
            sDTBNLabel.Name = "sDTBNLabel";
            sDTBNLabel.Size = new System.Drawing.Size(107, 16);
            sDTBNLabel.TabIndex = 10;
            sDTBNLabel.Text = "Số điện thoại:";
            // 
            // txtSdt
            // 
            this.txtSdt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bENHNHANBindingSource, "SDTBN", true));
            this.txtSdt.Location = new System.Drawing.Point(128, 302);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(176, 22);
            this.txtSdt.TabIndex = 11;
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(6, 222);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(61, 16);
            dIACHILabel.TabIndex = 8;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // txtDiachi
            // 
            this.txtDiachi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bENHNHANBindingSource, "DIACHI", true));
            this.txtDiachi.Location = new System.Drawing.Point(128, 222);
            this.txtDiachi.Multiline = true;
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(233, 57);
            this.txtDiachi.TabIndex = 9;
            // 
            // gIOITINHLabel
            // 
            gIOITINHLabel.AutoSize = true;
            gIOITINHLabel.Location = new System.Drawing.Point(6, 180);
            gIOITINHLabel.Name = "gIOITINHLabel";
            gIOITINHLabel.Size = new System.Drawing.Size(71, 16);
            gIOITINHLabel.TabIndex = 6;
            gIOITINHLabel.Text = "Giới tính:";
            // 
            // cbbGioitinh
            // 
            this.cbbGioitinh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bENHNHANBindingSource, "GIOITINH", true));
            this.cbbGioitinh.FormattingEnabled = true;
            this.cbbGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbbGioitinh.Location = new System.Drawing.Point(128, 177);
            this.cbbGioitinh.Name = "cbbGioitinh";
            this.cbbGioitinh.Size = new System.Drawing.Size(121, 24);
            this.cbbGioitinh.TabIndex = 7;
            // 
            // tUOIBNLabel
            // 
            tUOIBNLabel.AutoSize = true;
            tUOIBNLabel.Location = new System.Drawing.Point(6, 139);
            tUOIBNLabel.Name = "tUOIBNLabel";
            tUOIBNLabel.Size = new System.Drawing.Size(44, 16);
            tUOIBNLabel.TabIndex = 4;
            tUOIBNLabel.Text = "Tuổi:";
            // 
            // txtTuoi
            // 
            this.txtTuoi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bENHNHANBindingSource, "TUOIBN", true));
            this.txtTuoi.Location = new System.Drawing.Point(128, 136);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.Size = new System.Drawing.Size(100, 22);
            this.txtTuoi.TabIndex = 5;
            // 
            // tENBNLabel
            // 
            tENBNLabel.AutoSize = true;
            tENBNLabel.Location = new System.Drawing.Point(6, 95);
            tENBNLabel.Name = "tENBNLabel";
            tENBNLabel.Size = new System.Drawing.Size(117, 16);
            tENBNLabel.TabIndex = 2;
            tENBNLabel.Text = "Tên bệnh nhân:";
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bENHNHANBindingSource, "TENBN", true));
            this.txtTen.Location = new System.Drawing.Point(128, 92);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(233, 22);
            this.txtTen.TabIndex = 3;
            // 
            // mABNLabel
            // 
            mABNLabel.AutoSize = true;
            mABNLabel.Location = new System.Drawing.Point(6, 51);
            mABNLabel.Name = "mABNLabel";
            mABNLabel.Size = new System.Drawing.Size(112, 16);
            mABNLabel.TabIndex = 0;
            mABNLabel.Text = "Mã bệnh nhân:";
            // 
            // txtMa
            // 
            this.txtMa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bENHNHANBindingSource, "MABN", true));
            this.txtMa.Location = new System.Drawing.Point(128, 45);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(133, 22);
            this.txtMa.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.bENHNHANDataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(381, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 357);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Bệnh Nhân";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.btnLuu);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(381, 382);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(500, 80);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(259, 21);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(120, 37);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(59, 21);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 37);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // bENHNHANDataGridView
            // 
            this.bENHNHANDataGridView.AutoGenerateColumns = false;
            this.bENHNHANDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bENHNHANDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.bENHNHANDataGridView.DataSource = this.bENHNHANBindingSource;
            this.bENHNHANDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bENHNHANDataGridView.Location = new System.Drawing.Point(3, 18);
            this.bENHNHANDataGridView.Name = "bENHNHANDataGridView";
            this.bENHNHANDataGridView.Size = new System.Drawing.Size(494, 336);
            this.bENHNHANDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MABN";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Bệnh Nhân";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENBN";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Bệnh Nhân";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TUOIBN";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tuổi";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GIOITINH";
            this.dataGridViewTextBoxColumn4.HeaderText = "Giới Tính";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DIACHI";
            this.dataGridViewTextBoxColumn5.HeaderText = "Địa Chỉ";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SDTBN";
            this.dataGridViewTextBoxColumn6.HeaderText = "Số Điện Thoại";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "BHYT";
            this.dataGridViewTextBoxColumn7.HeaderText = "BHYT";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // bHYTLabel
            // 
            bHYTLabel.AutoSize = true;
            bHYTLabel.Location = new System.Drawing.Point(6, 351);
            bHYTLabel.Name = "bHYTLabel";
            bHYTLabel.Size = new System.Drawing.Size(57, 16);
            bHYTLabel.TabIndex = 12;
            bHYTLabel.Text = "BHYT:";
            // 
            // bHYTComboBox
            // 
            this.bHYTComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bENHNHANBindingSource, "BHYT", true));
            this.bHYTComboBox.FormattingEnabled = true;
            this.bHYTComboBox.Items.AddRange(new object[] {
            "Có",
            "Không"});
            this.bHYTComboBox.Location = new System.Drawing.Point(128, 348);
            this.bHYTComboBox.Name = "bHYTComboBox";
            this.bHYTComboBox.Size = new System.Drawing.Size(121, 24);
            this.bHYTComboBox.TabIndex = 13;
            // 
            // FBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(881, 462);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbBenhnhan);
            this.Controls.Add(this.bENHNHANBindingNavigator);
            this.Name = "FBenhNhan";
            this.Text = "Thêm Bệnh Nhân";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FBenhNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bENHNHANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bENHNHANBindingNavigator)).EndInit();
            this.bENHNHANBindingNavigator.ResumeLayout(false);
            this.bENHNHANBindingNavigator.PerformLayout();
            this.grbBenhnhan.ResumeLayout(false);
            this.grbBenhnhan.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bENHNHANDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource bENHNHANBindingSource;
        private DataSet1TableAdapters.BENHNHANTableAdapter bENHNHANTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bENHNHANBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bENHNHANBindingNavigatorSaveItem;
        private System.Windows.Forms.GroupBox grbBenhnhan;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.ComboBox cbbGioitinh;
        private System.Windows.Forms.TextBox txtTuoi;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView bENHNHANDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ComboBox bHYTComboBox;
    }
}