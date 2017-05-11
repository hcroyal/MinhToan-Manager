using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraScheduler;

namespace MinhToan_Manager.MyForm
{
    public partial class frm_SoDoPhong : DevExpress.XtraEditors.XtraForm
    {
        public frm_SoDoPhong()
        {
            InitializeComponent();
        }

        private void popupControlContainer2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Hide();
            frm_KhachLe frm = new frm_KhachLe();
            frm.lbl_ThongTinPhong.Text = lbl_TenPhong.Text;
            frm.ShowDialog();
            Show();
        }

        private void frm_SoDoPhong_Load(object sender, EventArgs e)
        {
            taonut();
        }
        private void taonut()
        {
            var query = (from w in Global.db.tbl_Phongs select w.TenPhong).ToList();
            int row = 0;
            int col = 0;
            for (int i = 0; i < query.Count; i++)
            {
                DropDownButton bt = new DropDownButton();
                bt.Text = query[i];
                bt.Size = new Size(70, 40);
                bt.Location = new Point(col * 85 + 20, row * 60 + 13);
                if (col == 8)
                {
                    row++;
                    col = 0;
                }
                else
                {
                    col++;
                }
                bt.MenuManager = barManager1;
                bt.DropDownControl = popupControlContainer2;
                bt.DropDownArrowStyle = DropDownArrowStyle.Hide;
                bt.Tag = query[i];
                bt.Name = "Phong" + query[i];
                bt.Click += Bt_Click;
                //bt.LookAndFeel.Style = LookAndFeelStyle.UltraFlat;
                var queryTinhTrang = (from w in Global.db.tbl_Phongs where w.TenPhong == query[i] select w.TinhTrang).FirstOrDefault();
                switch (queryTinhTrang)
                {
                    case "Sẵn sàng":
                        
                        bt.Appearance.BackColor = Color.White;
                        break;
                    case "Khách đặt":
                        bt.Image = Properties.Resources.icon_checkin;
                        bt.BackgroundImageLayout = ImageLayout.Zoom;
                        
                        break;
                    case "Có khách":
                        bt.Appearance.BackColor = Color.Gold;
                        bt.Appearance.BackColor2 = Color.Gold;
                        bt.AppearanceDropDown.BackColor = Color.Gold;
                        bt.AppearanceDropDown.BackColor2 = Color.Gold;

                        break;
                    case "Đến trong ngày":
                        bt.BackColor = Color.GreenYellow;
                        break;
                    case "Chuẩn bị đi":
                        bt.BackColor = Color.Green;
                        bt.ForeColor = Color.White;
                        break;
                    case "Phòng dơ":
                        bt.BackColor = Color.Gray;
                        bt.ForeColor = Color.White;
                        break;
                    case "Phòng hỏng":
                        bt.BackColor = Color.Red;
                        bt.ForeColor = Color.White;
                        break;
                }
                panelControl2.Controls.Add(bt);
            }
        }

        private void Bt_Click(object sender, EventArgs e)
        {
            lbl_TenPhong.Text = ((DropDownButton) sender).Tag + "";
        }
    }
}