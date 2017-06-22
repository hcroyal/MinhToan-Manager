using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MinhToan_Manager.MyForm
{
    public partial class frm_Login : DevExpress.XtraEditors.XtraForm
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
        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            txt_Username.Text = "hoangnt";
            txt_Password.Text = "123456";
        }

        private int solan=0;
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            var str = (from w in Global.db.tbl_Users where w.UserName == txt_Username.Text && w.Password == txt_Password.Text select w.UserName).FirstOrDefault();
            if (!string.IsNullOrEmpty(str))
            {
                Global.tenDangNhap = txt_Username.Text;
                Global.QuyenHan = (from w in Global.db.tbl_Users where w.UserName == txt_Username.Text select w.QuyenHan).FirstOrDefault();
                Global.HoTen = (from w in Global.db.tbl_Users where w.UserName == txt_Username.Text select w.FullName).FirstOrDefault();
                Global.gioiTinh = (from w in Global.db.tbl_Users where w.UserName == txt_Username.Text select w.GioiTinh).FirstOrDefault();
                DialogResult = DialogResult.OK;
            }
            else
            {
                solan++;
                if (solan>5)
                {
                    MessageBox.Show("Bạn đã đăng nhập sai quá số lần quy định");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Bạn nhập sai tên đăng nhập hoặc mật khâu, vui lòng thử lại!");}
            }
        }
    }
}