
namespace QLMHX
{
    partial class FrmCV
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
            System.Windows.Forms.Label idCVLabel;
            System.Windows.Forms.Label tenLabel;
            System.Windows.Forms.Label thoiGianLabel;
            System.Windows.Forms.Label khoiLuongLabel;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dgvCV = new System.Windows.Forms.DataGridView();
            this.idCVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoiLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.congViecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mUAHEXANHDataSet1 = new QLMHX.MUAHEXANHDataSet1();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.quanLyDS = new QLMHX.QuanLyDS();
            this.BtnThem = new DevExpress.XtraEditors.SimpleButton();
            this.BtnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGhi = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUndo = new DevExpress.XtraEditors.SimpleButton();
            this.BtnReload = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSua = new DevExpress.XtraEditors.SimpleButton();
            this.groupAction = new DevExpress.XtraEditors.GroupControl();
            this.pnlTHEMCV = new DevExpress.XtraEditors.PanelControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.khoiLuongSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.thoiGianSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.tenTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.idCVSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.congViecTableAdapter = new QLMHX.MUAHEXANHDataSet1TableAdapters.CongViecTableAdapter();
            this.tableAdapterManager = new QLMHX.MUAHEXANHDataSet1TableAdapters.TableAdapterManager();
            this.cTCVTableAdapter = new QLMHX.MUAHEXANHDataSet1TableAdapters.CTCVTableAdapter();
            this.cTCVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemChoAp = new System.Windows.Forms.ToolStripMenuItem();
            idCVLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            thoiGianLabel = new System.Windows.Forms.Label();
            khoiLuongLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.congViecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mUAHEXANHDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupAction)).BeginInit();
            this.groupAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTHEMCV)).BeginInit();
            this.pnlTHEMCV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoiLuongSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiGianSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idCVSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTCVBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idCVLabel
            // 
            idCVLabel.AutoSize = true;
            idCVLabel.Location = new System.Drawing.Point(65, 44);
            idCVLabel.Name = "idCVLabel";
            idCVLabel.Size = new System.Drawing.Size(55, 19);
            idCVLabel.TabIndex = 0;
            idCVLabel.Text = "Id CV:";
            idCVLabel.Visible = false;
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Location = new System.Drawing.Point(300, 43);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(42, 19);
            tenLabel.TabIndex = 2;
            tenLabel.Text = "Tên:";
            // 
            // thoiGianLabel
            // 
            thoiGianLabel.AutoSize = true;
            thoiGianLabel.Location = new System.Drawing.Point(41, 143);
            thoiGianLabel.Name = "thoiGianLabel";
            thoiGianLabel.Size = new System.Drawing.Size(84, 19);
            thoiGianLabel.TabIndex = 4;
            thoiGianLabel.Text = "Thời Gian:";
            // 
            // khoiLuongLabel
            // 
            khoiLuongLabel.AutoSize = true;
            khoiLuongLabel.Location = new System.Drawing.Point(391, 138);
            khoiLuongLabel.Name = "khoiLuongLabel";
            khoiLuongLabel.Size = new System.Drawing.Size(96, 19);
            khoiLuongLabel.TabIndex = 6;
            khoiLuongLabel.Text = "Khối Lượng:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dgvCV);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 82);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1357, 297);
            this.panelControl1.TabIndex = 13;
            // 
            // dgvCV
            // 
            this.dgvCV.AllowUserToAddRows = false;
            this.dgvCV.AutoGenerateColumns = false;
            this.dgvCV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCVDataGridViewTextBoxColumn,
            this.tenDataGridViewTextBoxColumn,
            this.thoiGianDataGridViewTextBoxColumn,
            this.khoiLuongDataGridViewTextBoxColumn});
            this.dgvCV.DataSource = this.congViecBindingSource;
            this.dgvCV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCV.Location = new System.Drawing.Point(2, 54);
            this.dgvCV.Name = "dgvCV";
            this.dgvCV.RowHeadersWidth = 62;
            this.dgvCV.RowTemplate.Height = 28;
            this.dgvCV.Size = new System.Drawing.Size(1353, 241);
            this.dgvCV.TabIndex = 1;
            this.dgvCV.SelectionChanged += new System.EventHandler(this.dgvCV_SelectionChanged);
            // 
            // idCVDataGridViewTextBoxColumn
            // 
            this.idCVDataGridViewTextBoxColumn.DataPropertyName = "IdCV";
            this.idCVDataGridViewTextBoxColumn.HeaderText = "IdCV";
            this.idCVDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idCVDataGridViewTextBoxColumn.Name = "idCVDataGridViewTextBoxColumn";
            this.idCVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Ten";
            this.tenDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            // 
            // thoiGianDataGridViewTextBoxColumn
            // 
            this.thoiGianDataGridViewTextBoxColumn.DataPropertyName = "ThoiGian";
            this.thoiGianDataGridViewTextBoxColumn.HeaderText = "ThoiGian";
            this.thoiGianDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.thoiGianDataGridViewTextBoxColumn.Name = "thoiGianDataGridViewTextBoxColumn";
            // 
            // khoiLuongDataGridViewTextBoxColumn
            // 
            this.khoiLuongDataGridViewTextBoxColumn.DataPropertyName = "KhoiLuong";
            this.khoiLuongDataGridViewTextBoxColumn.HeaderText = "KhoiLuong";
            this.khoiLuongDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.khoiLuongDataGridViewTextBoxColumn.Name = "khoiLuongDataGridViewTextBoxColumn";
            // 
            // congViecBindingSource
            // 
            this.congViecBindingSource.DataMember = "CongViec";
            this.congViecBindingSource.DataSource = this.mUAHEXANHDataSet1;
            // 
            // mUAHEXANHDataSet1
            // 
            this.mUAHEXANHDataSet1.DataSetName = "MUAHEXANHDataSet1";
            this.mUAHEXANHDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelControl3
            // 
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1353, 52);
            this.panelControl3.TabIndex = 0;
            // 
            // quanLyDS
            // 
            this.quanLyDS.DataSetName = "QuanLyDS";
            this.quanLyDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnThem
            // 
            this.BtnThem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnThem.Location = new System.Drawing.Point(6, 37);
            this.BtnThem.Margin = new System.Windows.Forms.Padding(4);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(121, 34);
            this.BtnThem.TabIndex = 2;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnXoa.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.BtnXoa.Location = new System.Drawing.Point(135, 37);
            this.BtnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(121, 34);
            this.BtnXoa.TabIndex = 3;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnGhi
            // 
            this.BtnGhi.Enabled = false;
            this.BtnGhi.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnGhi.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.BtnGhi.Location = new System.Drawing.Point(392, 37);
            this.BtnGhi.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGhi.Name = "BtnGhi";
            this.BtnGhi.Size = new System.Drawing.Size(121, 34);
            this.BtnGhi.TabIndex = 4;
            this.BtnGhi.Text = "Ghi";
            this.BtnGhi.Click += new System.EventHandler(this.BtnGhi_Click);
            // 
            // BtnUndo
            // 
            this.BtnUndo.Enabled = false;
            this.BtnUndo.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnUndo.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.BtnUndo.Location = new System.Drawing.Point(521, 37);
            this.BtnUndo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnUndo.Name = "BtnUndo";
            this.BtnUndo.Size = new System.Drawing.Size(121, 34);
            this.BtnUndo.TabIndex = 5;
            this.BtnUndo.Text = "Undo";
            this.BtnUndo.Click += new System.EventHandler(this.BtnUndo_Click);
            // 
            // BtnReload
            // 
            this.BtnReload.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnReload.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.BtnReload.Location = new System.Drawing.Point(649, 37);
            this.BtnReload.Margin = new System.Windows.Forms.Padding(4);
            this.BtnReload.Name = "BtnReload";
            this.BtnReload.Size = new System.Drawing.Size(121, 34);
            this.BtnReload.TabIndex = 6;
            this.BtnReload.Text = "Reload";
            this.BtnReload.Click += new System.EventHandler(this.BtnReload_Click);
            // 
            // BtnSua
            // 
            this.BtnSua.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnSua.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.BtnSua.Location = new System.Drawing.Point(264, 37);
            this.BtnSua.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(121, 34);
            this.BtnSua.TabIndex = 9;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // groupAction
            // 
            this.groupAction.Controls.Add(this.BtnSua);
            this.groupAction.Controls.Add(this.BtnReload);
            this.groupAction.Controls.Add(this.BtnUndo);
            this.groupAction.Controls.Add(this.BtnGhi);
            this.groupAction.Controls.Add(this.BtnXoa);
            this.groupAction.Controls.Add(this.BtnThem);
            this.groupAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupAction.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupAction.Location = new System.Drawing.Point(0, 0);
            this.groupAction.Margin = new System.Windows.Forms.Padding(4);
            this.groupAction.Name = "groupAction";
            this.groupAction.Size = new System.Drawing.Size(1357, 82);
            this.groupAction.TabIndex = 11;
            this.groupAction.Text = "Action";
            // 
            // pnlTHEMCV
            // 
            this.pnlTHEMCV.Controls.Add(this.dataGridView1);
            this.pnlTHEMCV.Controls.Add(khoiLuongLabel);
            this.pnlTHEMCV.Controls.Add(this.khoiLuongSpinEdit);
            this.pnlTHEMCV.Controls.Add(thoiGianLabel);
            this.pnlTHEMCV.Controls.Add(this.thoiGianSpinEdit);
            this.pnlTHEMCV.Controls.Add(tenLabel);
            this.pnlTHEMCV.Controls.Add(this.tenTextEdit);
            this.pnlTHEMCV.Controls.Add(idCVLabel);
            this.pnlTHEMCV.Controls.Add(this.idCVSpinEdit);
            this.pnlTHEMCV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTHEMCV.Location = new System.Drawing.Point(0, 379);
            this.pnlTHEMCV.Name = "pnlTHEMCV";
            this.pnlTHEMCV.Size = new System.Drawing.Size(1357, 313);
            this.pnlTHEMCV.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(711, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(644, 309);
            this.dataGridView1.TabIndex = 8;
            // 
            // khoiLuongSpinEdit
            // 
            this.khoiLuongSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.congViecBindingSource, "KhoiLuong", true));
            this.khoiLuongSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.khoiLuongSpinEdit.Location = new System.Drawing.Point(492, 129);
            this.khoiLuongSpinEdit.Name = "khoiLuongSpinEdit";
            this.khoiLuongSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.khoiLuongSpinEdit.Size = new System.Drawing.Size(150, 28);
            this.khoiLuongSpinEdit.TabIndex = 7;
            // 
            // thoiGianSpinEdit
            // 
            this.thoiGianSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.congViecBindingSource, "ThoiGian", true));
            this.thoiGianSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.thoiGianSpinEdit.Location = new System.Drawing.Point(126, 134);
            this.thoiGianSpinEdit.Name = "thoiGianSpinEdit";
            this.thoiGianSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.thoiGianSpinEdit.Size = new System.Drawing.Size(150, 28);
            this.thoiGianSpinEdit.TabIndex = 5;
            // 
            // tenTextEdit
            // 
            this.tenTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.congViecBindingSource, "Ten", true));
            this.tenTextEdit.Location = new System.Drawing.Point(348, 40);
            this.tenTextEdit.Name = "tenTextEdit";
            this.tenTextEdit.Size = new System.Drawing.Size(263, 26);
            this.tenTextEdit.TabIndex = 3;
            // 
            // idCVSpinEdit
            // 
            this.idCVSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.congViecBindingSource, "IdCV", true));
            this.idCVSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.idCVSpinEdit.Location = new System.Drawing.Point(126, 41);
            this.idCVSpinEdit.Name = "idCVSpinEdit";
            this.idCVSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idCVSpinEdit.Size = new System.Drawing.Size(150, 28);
            this.idCVSpinEdit.TabIndex = 1;
            this.idCVSpinEdit.Visible = false;
            // 
            // congViecTableAdapter
            // 
            this.congViecTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CongViecTableAdapter = this.congViecTableAdapter;
            this.tableAdapterManager.CTCVTableAdapter = this.cTCVTableAdapter;
            this.tableAdapterManager.DiaBanTableAdapter = null;
            this.tableAdapterManager.GiangVienTableAdapter = null;
            this.tableAdapterManager.KhenThuongTableAdapter = null;
            this.tableAdapterManager.KhoaTableAdapter = null;
            this.tableAdapterManager.NhaDanTableAdapter = null;
            this.tableAdapterManager.NhomGVTableAdapter = null;
            this.tableAdapterManager.NhomSVTableAdapter = null;
            this.tableAdapterManager.PCCVTableAdapter = null;
            this.tableAdapterManager.SinhVienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLMHX.MUAHEXANHDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XaTableAdapter = null;
            // 
            // cTCVTableAdapter
            // 
            this.cTCVTableAdapter.ClearBeforeFill = true;
            // 
            // cTCVBindingSource
            // 
            this.cTCVBindingSource.DataMember = "FK__CTCV__IdCV__571DF1D5";
            this.cTCVBindingSource.DataSource = this.congViecBindingSource;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemChoAp});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(188, 36);
            // 
            // btnThemChoAp
            // 
            this.btnThemChoAp.Name = "btnThemChoAp";
            this.btnThemChoAp.Size = new System.Drawing.Size(187, 32);
            this.btnThemChoAp.Text = "Thêm cho ấp";
            this.btnThemChoAp.Click += new System.EventHandler(this.btnThemChoAp_Click);
            // 
            // FrmCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 692);
            this.Controls.Add(this.pnlTHEMCV);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupAction);
            this.Name = "FrmCV";
            this.Text = "FrmCV";
            this.Load += new System.EventHandler(this.FrmCV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.congViecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mUAHEXANHDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupAction)).EndInit();
            this.groupAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTHEMCV)).EndInit();
            this.pnlTHEMCV.ResumeLayout(false);
            this.pnlTHEMCV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoiLuongSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiGianSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idCVSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTCVBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private QuanLyDS quanLyDS;
        private DevExpress.XtraEditors.SimpleButton BtnThem;
        private DevExpress.XtraEditors.SimpleButton BtnXoa;
        private DevExpress.XtraEditors.SimpleButton BtnGhi;
        private DevExpress.XtraEditors.SimpleButton BtnUndo;
        private DevExpress.XtraEditors.SimpleButton BtnReload;
        private DevExpress.XtraEditors.SimpleButton BtnSua;
        private DevExpress.XtraEditors.GroupControl groupAction;
        private MUAHEXANHDataSet1 mUAHEXANHDataSet1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl pnlTHEMCV;
        private System.Windows.Forms.BindingSource congViecBindingSource;
        private MUAHEXANHDataSet1TableAdapters.CongViecTableAdapter congViecTableAdapter;
        private MUAHEXANHDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.SpinEdit khoiLuongSpinEdit;
        private DevExpress.XtraEditors.SpinEdit thoiGianSpinEdit;
        private DevExpress.XtraEditors.TextEdit tenTextEdit;
        private DevExpress.XtraEditors.SpinEdit idCVSpinEdit;
        private MUAHEXANHDataSet1TableAdapters.CTCVTableAdapter cTCVTableAdapter;
        private System.Windows.Forms.BindingSource cTCVBindingSource;
        private System.Windows.Forms.DataGridView dgvCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoiLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThemChoAp;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}