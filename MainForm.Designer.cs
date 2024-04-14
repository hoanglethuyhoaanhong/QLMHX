namespace QLMHX
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupFunc = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDangXuat = new DevExpress.XtraEditors.SimpleButton();
            this.groupThongKe = new DevExpress.XtraEditors.GroupControl();
            this.btnDSKH = new DevExpress.XtraEditors.SimpleButton();
            this.btnLSTK = new DevExpress.XtraEditors.SimpleButton();
            this.btnLSGD = new DevExpress.XtraEditors.SimpleButton();
            this.groupDiaDiem = new DevExpress.XtraEditors.GroupControl();
            this.btnCuTru = new DevExpress.XtraEditors.SimpleButton();
            this.btnNhaDan = new DevExpress.XtraEditors.SimpleButton();
            this.btnDiaBan = new DevExpress.XtraEditors.SimpleButton();
            this.groupQuanLy = new DevExpress.XtraEditors.GroupControl();
            this.BtnKhoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSinhVien = new DevExpress.XtraEditors.SimpleButton();
            this.btnGiangVien = new DevExpress.XtraEditors.SimpleButton();
            this.groupTaoNhom = new DevExpress.XtraEditors.GroupControl();
            this.btnNhomSV = new DevExpress.XtraEditors.SimpleButton();
            this.btnNhomGV = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.btnXa = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupFunc)).BeginInit();
            this.groupFunc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongKe)).BeginInit();
            this.groupThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupDiaDiem)).BeginInit();
            this.groupDiaDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupQuanLy)).BeginInit();
            this.groupQuanLy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupTaoNhom)).BeginInit();
            this.groupTaoNhom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupFunc
            // 
            this.groupFunc.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupFunc.Controls.Add(this.groupControl1);
            this.groupFunc.Controls.Add(this.groupThongKe);
            this.groupFunc.Controls.Add(this.groupDiaDiem);
            this.groupFunc.Controls.Add(this.groupQuanLy);
            this.groupFunc.Controls.Add(this.groupTaoNhom);
            this.groupFunc.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupFunc.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupFunc.Location = new System.Drawing.Point(0, 0);
            this.groupFunc.Name = "groupFunc";
            this.groupFunc.Size = new System.Drawing.Size(1918, 124);
            this.groupFunc.TabIndex = 4;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.btnExit);
            this.groupControl1.Controls.Add(this.btnDangXuat);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(1249, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(205, 120);
            this.groupControl1.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnExit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExit.ImageOptions.SvgImage")));
            this.btnExit.Location = new System.Drawing.Point(105, 31);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 84);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnDangXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangXuat.ImageOptions.SvgImage")));
            this.btnDangXuat.Location = new System.Drawing.Point(5, 31);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(94, 84);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // groupThongKe
            // 
            this.groupThongKe.AppearanceCaption.Options.UseTextOptions = true;
            this.groupThongKe.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupThongKe.Controls.Add(this.btnDSKH);
            this.groupThongKe.Controls.Add(this.btnLSTK);
            this.groupThongKe.Controls.Add(this.btnLSGD);
            this.groupThongKe.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupThongKe.Location = new System.Drawing.Point(939, 0);
            this.groupThongKe.Name = "groupThongKe";
            this.groupThongKe.Size = new System.Drawing.Size(304, 120);
            this.groupThongKe.TabIndex = 6;
            this.groupThongKe.Text = "Thong Ke";
            // 
            // btnDSKH
            // 
            this.btnDSKH.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnDSKH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDSKH.ImageOptions.SvgImage")));
            this.btnDSKH.Location = new System.Drawing.Point(205, 31);
            this.btnDSKH.Name = "btnDSKH";
            this.btnDSKH.Size = new System.Drawing.Size(94, 84);
            this.btnDSKH.TabIndex = 5;
            this.btnDSKH.Text = "DS Khách Hàng";
            // 
            // btnLSTK
            // 
            this.btnLSTK.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnLSTK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLSTK.ImageOptions.SvgImage")));
            this.btnLSTK.Location = new System.Drawing.Point(105, 31);
            this.btnLSTK.Name = "btnLSTK";
            this.btnLSTK.Size = new System.Drawing.Size(94, 84);
            this.btnLSTK.TabIndex = 4;
            this.btnLSTK.Text = "LS Tài Khoản";
            // 
            // btnLSGD
            // 
            this.btnLSGD.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnLSGD.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLSGD.ImageOptions.SvgImage")));
            this.btnLSGD.Location = new System.Drawing.Point(5, 31);
            this.btnLSGD.Name = "btnLSGD";
            this.btnLSGD.Size = new System.Drawing.Size(94, 84);
            this.btnLSGD.TabIndex = 2;
            this.btnLSGD.Text = "LS Giao Dịch";
            // 
            // groupDiaDiem
            // 
            this.groupDiaDiem.AppearanceCaption.Options.UseTextOptions = true;
            this.groupDiaDiem.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupDiaDiem.Controls.Add(this.btnXa);
            this.groupDiaDiem.Controls.Add(this.btnCuTru);
            this.groupDiaDiem.Controls.Add(this.btnNhaDan);
            this.groupDiaDiem.Controls.Add(this.btnDiaBan);
            this.groupDiaDiem.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupDiaDiem.Location = new System.Drawing.Point(525, 0);
            this.groupDiaDiem.Name = "groupDiaDiem";
            this.groupDiaDiem.Size = new System.Drawing.Size(408, 120);
            this.groupDiaDiem.TabIndex = 5;
            this.groupDiaDiem.Text = "Địa Điểm";
            // 
            // btnCuTru
            // 
            this.btnCuTru.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCuTru.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCuTru.ImageOptions.SvgImage")));
            this.btnCuTru.Location = new System.Drawing.Point(205, 31);
            this.btnCuTru.Name = "btnCuTru";
            this.btnCuTru.Size = new System.Drawing.Size(94, 84);
            this.btnCuTru.TabIndex = 5;
            this.btnCuTru.Text = "Ấp";
            this.btnCuTru.Click += new System.EventHandler(this.btnCuTru_Click);
            // 
            // btnNhaDan
            // 
            this.btnNhaDan.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnNhaDan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNhaDan.ImageOptions.SvgImage")));
            this.btnNhaDan.Location = new System.Drawing.Point(305, 31);
            this.btnNhaDan.Name = "btnNhaDan";
            this.btnNhaDan.Size = new System.Drawing.Size(94, 84);
            this.btnNhaDan.TabIndex = 4;
            this.btnNhaDan.Text = "Nhà Dân";
            this.btnNhaDan.Click += new System.EventHandler(this.btnNhaDan_Click);
            // 
            // btnDiaBan
            // 
            this.btnDiaBan.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnDiaBan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDiaBan.ImageOptions.SvgImage")));
            this.btnDiaBan.Location = new System.Drawing.Point(5, 31);
            this.btnDiaBan.Name = "btnDiaBan";
            this.btnDiaBan.Size = new System.Drawing.Size(94, 84);
            this.btnDiaBan.TabIndex = 2;
            this.btnDiaBan.Text = "Địa Bàn";
            this.btnDiaBan.Click += new System.EventHandler(this.btnDiaBan_Click);
            // 
            // groupQuanLy
            // 
            this.groupQuanLy.AppearanceCaption.Options.UseTextOptions = true;
            this.groupQuanLy.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupQuanLy.Controls.Add(this.BtnKhoa);
            this.groupQuanLy.Controls.Add(this.btnSinhVien);
            this.groupQuanLy.Controls.Add(this.btnGiangVien);
            this.groupQuanLy.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupQuanLy.Location = new System.Drawing.Point(0, 0);
            this.groupQuanLy.Name = "groupQuanLy";
            this.groupQuanLy.Size = new System.Drawing.Size(307, 120);
            this.groupQuanLy.TabIndex = 0;
            this.groupQuanLy.Text = "Quản Lý";
            // 
            // BtnKhoa
            // 
            this.BtnKhoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnKhoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnKhoa.ImageOptions.SvgImage")));
            this.BtnKhoa.Location = new System.Drawing.Point(205, 31);
            this.BtnKhoa.Name = "BtnKhoa";
            this.BtnKhoa.Size = new System.Drawing.Size(94, 84);
            this.BtnKhoa.TabIndex = 2;
            this.BtnKhoa.Text = "Khoa";
            this.BtnKhoa.Click += new System.EventHandler(this.BtnKhoa_Click);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnSinhVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSinhVien.ImageOptions.SvgImage")));
            this.btnSinhVien.Location = new System.Drawing.Point(105, 31);
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.Size = new System.Drawing.Size(94, 84);
            this.btnSinhVien.TabIndex = 1;
            this.btnSinhVien.Text = "Sinh Viên";
            this.btnSinhVien.Click += new System.EventHandler(this.btnSinhVien_Click);
            // 
            // btnGiangVien
            // 
            this.btnGiangVien.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnGiangVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGiangVien.ImageOptions.SvgImage")));
            this.btnGiangVien.Location = new System.Drawing.Point(5, 31);
            this.btnGiangVien.Name = "btnGiangVien";
            this.btnGiangVien.Size = new System.Drawing.Size(94, 84);
            this.btnGiangVien.TabIndex = 0;
            this.btnGiangVien.Text = "Giảng Viên";
            this.btnGiangVien.Click += new System.EventHandler(this.btnGiangVien_Click);
            // 
            // groupTaoNhom
            // 
            this.groupTaoNhom.AppearanceCaption.Options.UseTextOptions = true;
            this.groupTaoNhom.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupTaoNhom.Controls.Add(this.btnNhomSV);
            this.groupTaoNhom.Controls.Add(this.btnNhomGV);
            this.groupTaoNhom.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupTaoNhom.Location = new System.Drawing.Point(313, 0);
            this.groupTaoNhom.Name = "groupTaoNhom";
            this.groupTaoNhom.Size = new System.Drawing.Size(206, 120);
            this.groupTaoNhom.TabIndex = 1;
            this.groupTaoNhom.Text = "Phân Nhóm";
            // 
            // btnNhomSV
            // 
            this.btnNhomSV.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnNhomSV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNhomSV.ImageOptions.SvgImage")));
            this.btnNhomSV.Location = new System.Drawing.Point(105, 31);
            this.btnNhomSV.Name = "btnNhomSV";
            this.btnNhomSV.Size = new System.Drawing.Size(94, 84);
            this.btnNhomSV.TabIndex = 4;
            this.btnNhomSV.Text = "Sinh Viên";
            this.btnNhomSV.Click += new System.EventHandler(this.btnNhomSV_Click);
            // 
            // btnNhomGV
            // 
            this.btnNhomGV.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnNhomGV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNhomGV.ImageOptions.SvgImage")));
            this.btnNhomGV.Location = new System.Drawing.Point(5, 31);
            this.btnNhomGV.Name = "btnNhomGV";
            this.btnNhomGV.Size = new System.Drawing.Size(94, 84);
            this.btnNhomGV.TabIndex = 2;
            this.btnNhomGV.Text = "Giảng Viên";
            this.btnNhomGV.Click += new System.EventHandler(this.btnNhomGV_Click);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // btnXa
            // 
            this.btnXa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnXa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnXa.Location = new System.Drawing.Point(105, 31);
            this.btnXa.Name = "btnXa";
            this.btnXa.Size = new System.Drawing.Size(94, 84);
            this.btnXa.TabIndex = 6;
            this.btnXa.Text = "Xã";
            this.btnXa.Click += new System.EventHandler(this.btnXa_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1918, 1040);
            this.Controls.Add(this.groupFunc);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupFunc)).EndInit();
            this.groupFunc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupThongKe)).EndInit();
            this.groupThongKe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupDiaDiem)).EndInit();
            this.groupDiaDiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupQuanLy)).EndInit();
            this.groupQuanLy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupTaoNhom)).EndInit();
            this.groupTaoNhom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupFunc;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnDangXuat;
        private DevExpress.XtraEditors.GroupControl groupThongKe;
        private DevExpress.XtraEditors.SimpleButton btnDSKH;
        private DevExpress.XtraEditors.SimpleButton btnLSTK;
        private DevExpress.XtraEditors.SimpleButton btnLSGD;
        private DevExpress.XtraEditors.GroupControl groupDiaDiem;
        private DevExpress.XtraEditors.SimpleButton btnCuTru;
        private DevExpress.XtraEditors.SimpleButton btnNhaDan;
        private DevExpress.XtraEditors.SimpleButton btnDiaBan;
        private DevExpress.XtraEditors.GroupControl groupQuanLy;
        private DevExpress.XtraEditors.SimpleButton btnSinhVien;
        private DevExpress.XtraEditors.SimpleButton btnGiangVien;
        private DevExpress.XtraEditors.GroupControl groupTaoNhom;
        private DevExpress.XtraEditors.SimpleButton btnNhomSV;
        private DevExpress.XtraEditors.SimpleButton btnNhomGV;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraEditors.SimpleButton BtnKhoa;
        private DevExpress.XtraEditors.SimpleButton btnXa;
    }
}