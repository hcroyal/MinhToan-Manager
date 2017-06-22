using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using MinhToan_Manager.Properties;
using DevExpress.XtraScheduler;

namespace MinhToan_Manager.MyForm
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
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
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            UserLookAndFeel.Default.SkinName = Settings.Default.ApplicationSkinName;
            if (Global.gioiTinh == "nam")
            {
                pic_User.Image = Image.FromFile(@"F:\Dropbox\Hoc tap\DoAnTotNghiep\MinhToan-Manager\MinhToan-Manager\MinhToan-Manager\Resources\nam.png");
                pic_User.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pic_User.Image = Image.FromFile(@"F:\Dropbox\Hoc tap\DoAnTotNghiep\MinhToan-Manager\MinhToan-Manager\MinhToan-Manager\Resources\nu.png");
                pic_User.SizeMode = PictureBoxSizeMode.Zoom;
            }
            lbl_HoTen.Text = Global.HoTen;
            lbl_TenDangNhap.Text = Global.tenDangNhap;
            lbl_QuyenHan.Text = Global.QuyenHan;
        }

        private void btn_DangNhapLai_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void btn_Thoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.ApplicationSkinName = UserLookAndFeel.Default.SkinName;
            Settings.Default.Save();
        }
        public bool CheckActivate(Type type)
        {
            foreach (var item in tabbedView1.Documents)
            {
                if (item.Control.GetType() == type)
                {
                    
                    tabbedView1.Controller.Activate(item);
                    return true;
                }
            }
            return false;
        }

        private void btn_SoDo_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (CheckActivate(typeof(frm_SoDoPhong))) return;
            var form = new frm_SoDoPhong { MdiParent = this };
            form.Show();
        }

        private void btn_KhachLe_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (CheckActivate(typeof(frm_KhachLe))) return;
            var form = new frm_KhachLe { MdiParent = this };
            form.Show();
        }

        private void btn_QuanLyPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (CheckActivate(typeof(frm_QuanLyPhong))) return;
            var form = new frm_QuanLyPhong() { MdiParent = this };
            form.Show();
        }
    }
}