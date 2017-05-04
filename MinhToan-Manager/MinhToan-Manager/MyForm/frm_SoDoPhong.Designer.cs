namespace MinhToan_Manager.MyForm
{
    partial class frm_SoDoPhong
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.date_ChonNgay = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.date_NgayDen = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.date_NgayDi = new DevExpress.XtraEditors.DateEdit();
            this.btn_KiemTraPhongTrong = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TenKhachHang = new DevExpress.XtraEditors.TextEdit();
            this.cbb_TrangThai = new System.Windows.Forms.ComboBox();
            this.btn_TimKiem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_ChonNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_ChonNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayDen.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayDen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayDi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayDi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKhachHang.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl3);
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(204, 729);
            this.panelControl1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.date_ChonNgay);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(200, 71);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Chọn ngày";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btn_KiemTraPhongTrong);
            this.groupControl2.Controls.Add(this.date_NgayDi);
            this.groupControl2.Controls.Add(this.date_NgayDen);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(2, 73);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(200, 123);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Kiểm tra phòng trống";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btn_TimKiem);
            this.groupControl3.Controls.Add(this.cbb_TrangThai);
            this.groupControl3.Controls.Add(this.txt_TenKhachHang);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl3.Location = new System.Drawing.Point(2, 196);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(200, 127);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Tìm kiếm";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ngày:";
            // 
            // date_ChonNgay
            // 
            this.date_ChonNgay.EditValue = null;
            this.date_ChonNgay.Location = new System.Drawing.Point(45, 34);
            this.date_ChonNgay.Name = "date_ChonNgay";
            this.date_ChonNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_ChonNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_ChonNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.date_ChonNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_ChonNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.date_ChonNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_ChonNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.date_ChonNgay.Size = new System.Drawing.Size(145, 20);
            this.date_ChonNgay.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Ngày đến:";
            // 
            // date_NgayDen
            // 
            this.date_NgayDen.EditValue = null;
            this.date_NgayDen.Location = new System.Drawing.Point(66, 34);
            this.date_NgayDen.Name = "date_NgayDen";
            this.date_NgayDen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_NgayDen.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_NgayDen.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.date_NgayDen.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_NgayDen.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.date_NgayDen.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_NgayDen.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.date_NgayDen.Size = new System.Drawing.Size(124, 20);
            this.date_NgayDen.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(10, 63);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Ngày đi:";
            // 
            // date_NgayDi
            // 
            this.date_NgayDi.EditValue = null;
            this.date_NgayDi.Location = new System.Drawing.Point(66, 60);
            this.date_NgayDi.Name = "date_NgayDi";
            this.date_NgayDi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_NgayDi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_NgayDi.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.date_NgayDi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_NgayDi.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.date_NgayDi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_NgayDi.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.date_NgayDi.Size = new System.Drawing.Size(124, 20);
            this.date_NgayDi.TabIndex = 1;
            // 
            // btn_KiemTraPhongTrong
            // 
            this.btn_KiemTraPhongTrong.Location = new System.Drawing.Point(10, 90);
            this.btn_KiemTraPhongTrong.Name = "btn_KiemTraPhongTrong";
            this.btn_KiemTraPhongTrong.Size = new System.Drawing.Size(180, 23);
            this.btn_KiemTraPhongTrong.TabIndex = 2;
            this.btn_KiemTraPhongTrong.Text = "Kiểm tra phòng trống";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(10, 32);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(38, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Tên KH:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(10, 61);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(53, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Trạng thái:";
            // 
            // txt_TenKhachHang
            // 
            this.txt_TenKhachHang.Location = new System.Drawing.Point(69, 29);
            this.txt_TenKhachHang.Name = "txt_TenKhachHang";
            this.txt_TenKhachHang.Size = new System.Drawing.Size(121, 20);
            this.txt_TenKhachHang.TabIndex = 1;
            // 
            // cbb_TrangThai
            // 
            this.cbb_TrangThai.FormattingEnabled = true;
            this.cbb_TrangThai.Location = new System.Drawing.Point(69, 58);
            this.cbb_TrangThai.Name = "cbb_TrangThai";
            this.cbb_TrangThai.Size = new System.Drawing.Size(121, 21);
            this.cbb_TrangThai.TabIndex = 2;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(10, 85);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(180, 23);
            this.btn_TimKiem.TabIndex = 2;
            this.btn_TimKiem.Text = "Tìm kiếm";
            // 
            // frm_SoDoPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panelControl1);
            this.Name = "frm_SoDoPhong";
            this.Text = "frm_SoDoPhong";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_ChonNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_ChonNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayDen.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayDen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayDi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayDi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKhachHang.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btn_TimKiem;
        private System.Windows.Forms.ComboBox cbb_TrangThai;
        private DevExpress.XtraEditors.TextEdit txt_TenKhachHang;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btn_KiemTraPhongTrong;
        private DevExpress.XtraEditors.DateEdit date_NgayDi;
        private DevExpress.XtraEditors.DateEdit date_NgayDen;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit date_ChonNgay;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}