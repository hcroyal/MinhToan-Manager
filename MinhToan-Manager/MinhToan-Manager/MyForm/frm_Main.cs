using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using MinhToan_Manager.Properties;

namespace MinhToan_Manager.MyForm
{
    public partial class frm_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        bool minimizedToTray;
        NotifyIcon notifyIcon;

        #region Chỉ hiển chạy 1 form
        protected override void WndProc(ref Message message)
        {
            if (message.Msg == SingleInstance.WM_SHOWFIRSTINSTANCE)
            {
                ShowWindow();
            }
            base.WndProc(ref message);
        }
        private void btnMinToTray_Click(object sender, EventArgs e)
        {
            // Tie this function to a button on your main form that will minimize your
            // application to the notification icon area (aka system tray).
            MinimizeToTray();
        }
        void MinimizeToTray()
        {
            notifyIcon = new NotifyIcon();
            //notifyIcon.Click += new EventHandler(NotifyIconClick);
            notifyIcon.DoubleClick += new EventHandler(NotifyIconClick);
            notifyIcon.Icon = this.Icon;
            notifyIcon.Text = ProgramInfo.AssemblyTitle;
            notifyIcon.Visible = true;
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
            minimizedToTray = true;
        }
        public void ShowWindow()
        {
            if (minimizedToTray)
            {
                notifyIcon.Visible = false;
                this.Show();
                this.WindowState = FormWindowState.Normal;
                minimizedToTray = false;
            }
            else
            {
                WinApi.ShowToFront(this.Handle);
            }
        }
        void NotifyIconClick(Object sender, System.EventArgs e)
        {
            ShowWindow();
        }

        #endregion
        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            if (Global.gioiTinh=="nam")
            {
                pic_User.Image = Image.FromFile(@"F:\Hoc tap\DoAnTotNghiep\MinhToan-Manager\MinhToan-Manager\MinhToan-Manager\Resources\nam.png");
                pic_User.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pic_User.Image = Image.FromFile(@"F:\Hoc tap\DoAnTotNghiep\MinhToan-Manager\MinhToan-Manager\MinhToan-Manager\Resources\nu.png");
                pic_User.SizeMode = PictureBoxSizeMode.Zoom;
            }
            lbl_HoTen.Text = Global.HoTen;
            lbl_TenDangNhap.Text = Global.tenDangNhap;
            lbl_QuyenHan.Text = Global.QuyenHan;
        }

        //private void btn_DangNhapLai_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    DialogResult = DialogResult.Yes;
        //    Close();
        //}

        //private void btn_Thoat_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    Application.Exit();
        //}

        private void skinRibbonGalleryBarItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
    
        }
    }
}