namespace MinhToan_Manager.MyForm
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_DangNhapLai = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Thoat = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.page_KinhDoanh = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.page_LeTan = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.page_NhaHang = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.page_BuongPhong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.page_BaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.page_KeToan = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.page_HeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dock_ChucNang = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbl_QuyenHan = new DevExpress.XtraEditors.LabelControl();
            this.lbl_HoTen = new DevExpress.XtraEditors.LabelControl();
            this.lbl_TenDangNhap = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic_User = new System.Windows.Forms.PictureBox();
            this.btn_SoDo = new DevExpress.XtraBars.BarButtonItem();
            this.btn_KhachLe = new DevExpress.XtraBars.BarButtonItem();
            this.btn_KhachDoan = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DanhSachDatPhong = new DevExpress.XtraBars.BarButtonItem();
            this.ZA = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dock_ChucNang.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_User)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationIcon = global::MinhToan_Manager.Properties.Resources.Logo1;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btn_DangNhapLai,
            this.btn_Thoat,
            this.skinRibbonGalleryBarItem1,
            this.btn_SoDo,
            this.btn_KhachLe,
            this.btn_KhachDoan,
            this.btn_DanhSachDatPhong,
            this.ZA});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 9;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.page_KinhDoanh,
            this.page_LeTan,
            this.page_NhaHang,
            this.page_BuongPhong,
            this.page_BaoCao,
            this.page_KeToan,
            this.page_HeThong});
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbon.Size = new System.Drawing.Size(912, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btn_DangNhapLai
            // 
            this.btn_DangNhapLai.Caption = "Đăng nhập lại";
            this.btn_DangNhapLai.Id = 1;
            this.btn_DangNhapLai.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DangNhapLai.ImageOptions.LargeImage")));
            this.btn_DangNhapLai.Name = "btn_DangNhapLai";
            this.btn_DangNhapLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DangNhapLai_ItemClick);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Caption = "Thoát";
            this.btn_Thoat.Id = 2;
            this.btn_Thoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.ImageOptions.LargeImage")));
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Thoat_ItemClick);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 3;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // page_KinhDoanh
            // 
            this.page_KinhDoanh.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.page_KinhDoanh.Name = "page_KinhDoanh";
            this.page_KinhDoanh.Text = "Kinh doanh";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_SoDo);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_KhachLe);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_KhachDoan);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_DanhSachDatPhong);
            this.ribbonPageGroup1.ItemLinks.Add(this.ZA);
            this.ribbonPageGroup1.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // page_LeTan
            // 
            this.page_LeTan.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.page_LeTan.Name = "page_LeTan";
            this.page_LeTan.Text = "Lễ tân";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // page_NhaHang
            // 
            this.page_NhaHang.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.page_NhaHang.Name = "page_NhaHang";
            this.page_NhaHang.Text = "Nhà hàng";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // page_BuongPhong
            // 
            this.page_BuongPhong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.page_BuongPhong.Name = "page_BuongPhong";
            this.page_BuongPhong.Text = "Buồng phòng";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // page_BaoCao
            // 
            this.page_BaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.page_BaoCao.Name = "page_BaoCao";
            this.page_BaoCao.Text = "Báo cáo";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // page_KeToan
            // 
            this.page_KeToan.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.page_KeToan.Name = "page_KeToan";
            this.page_KeToan.Text = "Kế toán";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "ribbonPageGroup6";
            // 
            // page_HeThong
            // 
            this.page_HeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7,
            this.ribbonPageGroup8});
            this.page_HeThong.Name = "page_HeThong";
            this.page_HeThong.Text = "Hệ thống";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btn_DangNhapLai);
            this.ribbonPageGroup7.ItemLinks.Add(this.btn_Thoat);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "Giao diện";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 610);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(912, 31);
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dock_ChucNang});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl"});
            // 
            // dock_ChucNang
            // 
            this.dock_ChucNang.Controls.Add(this.dockPanel1_Container);
            this.dock_ChucNang.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dock_ChucNang.ID = new System.Guid("f067683c-26de-4689-8f3e-5bbc02bc15d5");
            this.dock_ChucNang.Location = new System.Drawing.Point(0, 143);
            this.dock_ChucNang.Name = "dock_ChucNang";
            this.dock_ChucNang.OriginalSize = new System.Drawing.Size(200, 200);
            this.dock_ChucNang.Size = new System.Drawing.Size(200, 467);
            this.dock_ChucNang.Text = "Chức năng";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.navBarControl1);
            this.dockPanel1_Container.Controls.Add(this.panelControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(191, 440);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 191;
            this.navBarControl1.Size = new System.Drawing.Size(191, 196);
            this.navBarControl1.TabIndex = 4;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "navBarGroup1";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lbl_QuyenHan);
            this.panelControl1.Controls.Add(this.lbl_HoTen);
            this.panelControl1.Controls.Add(this.lbl_TenDangNhap);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Controls.Add(this.pic_User);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 196);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(191, 244);
            this.panelControl1.TabIndex = 3;
            // 
            // lbl_QuyenHan
            // 
            this.lbl_QuyenHan.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbl_QuyenHan.Appearance.Options.UseFont = true;
            this.lbl_QuyenHan.Location = new System.Drawing.Point(84, 125);
            this.lbl_QuyenHan.Name = "lbl_QuyenHan";
            this.lbl_QuyenHan.Size = new System.Drawing.Size(75, 16);
            this.lbl_QuyenHan.TabIndex = 2;
            this.lbl_QuyenHan.Text = "labelControl4";
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbl_HoTen.Appearance.Options.UseFont = true;
            this.lbl_HoTen.Location = new System.Drawing.Point(63, 99);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(75, 16);
            this.lbl_HoTen.TabIndex = 2;
            this.lbl_HoTen.Text = "labelControl4";
            // 
            // lbl_TenDangNhap
            // 
            this.lbl_TenDangNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbl_TenDangNhap.Appearance.Options.UseFont = true;
            this.lbl_TenDangNhap.Location = new System.Drawing.Point(63, 72);
            this.lbl_TenDangNhap.Name = "lbl_TenDangNhap";
            this.lbl_TenDangNhap.Size = new System.Drawing.Size(75, 16);
            this.lbl_TenDangNhap.TabIndex = 2;
            this.lbl_TenDangNhap.Text = "labelControl4";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(5, 125);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 17);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Quyền hạn:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 99);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Họ tên:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 72);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tên User:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = global::MinhToan_Manager.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(2, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pic_User
            // 
            this.pic_User.Dock = System.Windows.Forms.DockStyle.Top;
            this.pic_User.Location = new System.Drawing.Point(2, 2);
            this.pic_User.Name = "pic_User";
            this.pic_User.Size = new System.Drawing.Size(187, 66);
            this.pic_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_User.TabIndex = 0;
            this.pic_User.TabStop = false;
            // 
            // btn_SoDo
            // 
            this.btn_SoDo.Caption = "Sơ đồ";
            this.btn_SoDo.Id = 4;
            this.btn_SoDo.Name = "btn_SoDo";
            // 
            // btn_KhachLe
            // 
            this.btn_KhachLe.Caption = "Khách lẻ";
            this.btn_KhachLe.Id = 5;
            this.btn_KhachLe.Name = "btn_KhachLe";
            // 
            // btn_KhachDoan
            // 
            this.btn_KhachDoan.Caption = "Khách đoàn";
            this.btn_KhachDoan.Id = 6;
            this.btn_KhachDoan.Name = "btn_KhachDoan";
            // 
            // btn_DanhSachDatPhong
            // 
            this.btn_DanhSachDatPhong.Caption = "DS Đặt phòng";
            this.btn_DanhSachDatPhong.Id = 7;
            this.btn_DanhSachDatPhong.Name = "btn_DanhSachDatPhong";
            // 
            // ZA
            // 
            this.ZA.Caption = "Tìm kiếm";
            this.ZA.Id = 8;
            this.ZA.Name = "ZA";
            // 
            // Main
            // 
            this.AllowMdiBar = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 641);
            this.Controls.Add(this.dock_ChucNang);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Minh Toàn Hotel Galaxy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dock_ChucNang.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage page_KinhDoanh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dock_ChucNang;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lbl_QuyenHan;
        private DevExpress.XtraEditors.LabelControl lbl_HoTen;
        private DevExpress.XtraEditors.LabelControl lbl_TenDangNhap;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pic_User;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage page_LeTan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage page_NhaHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage page_BuongPhong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage page_BaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btn_DangNhapLai;
        private DevExpress.XtraBars.Ribbon.RibbonPage page_KeToan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPage page_HeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem btn_Thoat;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.BarButtonItem btn_SoDo;
        private DevExpress.XtraBars.BarButtonItem btn_KhachLe;
        private DevExpress.XtraBars.BarButtonItem btn_KhachDoan;
        private DevExpress.XtraBars.BarButtonItem btn_DanhSachDatPhong;
        private DevExpress.XtraBars.BarButtonItem ZA;
    }
}