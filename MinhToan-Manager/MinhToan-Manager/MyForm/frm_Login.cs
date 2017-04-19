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
        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            txt_Username.Text = "";
            txt_Password.Text = "";
        }

        private int solan=0;
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            var str = (from w in Global.db.tbl_Users
                where w.UserName == txt_Username.Text && w.Password == txt_Password.Text
                select w.UserName).FirstOrDefault();
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