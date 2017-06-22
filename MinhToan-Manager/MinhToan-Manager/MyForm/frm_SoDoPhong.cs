using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraScheduler;

namespace MinhToan_Manager.MyForm
{
    public partial class frm_SoDoPhong : DevExpress.XtraEditors.XtraForm
    {
        private int maPhong;
        public frm_SoDoPhong()
        {
            InitializeComponent();
        }

        private void popupControlContainer2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            frm_KhachLe frm = new frm_KhachLe();
            frm.lbl_ThongTinPhong.Text = lbl_TenPhong.Text;
            frm.maphong = maPhong;
            popupControlContainer2.HidePopup();
            frm.ShowDialog();
       
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
                bt.Size = new Size(140, 40);
                bt.Location = new Point(col * 160 + 15, row * 80 + 20);
                if (col == 4)
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
                var maphong = (from w in Global.db.tbl_Phongs where w.TenPhong == query[i] select w.MaPhong).FirstOrDefault();
                bt.Name = maphong+"";
                bt.Click += Bt_Click;
                bt.ButtonStyle = BorderStyles.Flat;
                bt.Appearance.Options.UseBackColor = true;
                bt.Appearance.Options.UseForeColor = true;
                bt.Appearance.Options.UseTextOptions = true;
                bt.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
                bt.Font = new Font("Tahoma", 15, FontStyle.Bold);
               
                var queryTinhTrang = (from w in Global.db.tbl_Phongs where w.TenPhong == query[i] select w.TinhTrang).FirstOrDefault();
                switch (queryTinhTrang)
                {
                    case "Sẵn sàng":
                        
                        bt.Appearance.BackColor = Color.White;
                        break;
                    case "Khách đặt":
                        bt.BackgroundImage = Properties.Resources.icon_checkin;
                        bt.BackgroundImageLayout = ImageLayout.Zoom;
                        bt.Appearance.BackColor = Color.Transparent;
                        bt.Appearance.BackColor2 = Color.Transparent;
                        bt.AppearanceHovered.Options.UseBackColor = false;
                        
                        break;
                    case "Có khách":
                        bt.Appearance.BackColor = Color.Gold;
                        bt.Appearance.BackColor2 = Color.Gold;

                        break;
                    case "Đến trong ngày":
                        bt.Appearance.BackColor = Color.GreenYellow;
                        break;
                    case "Chuẩn bị đi":
                        bt.Appearance.BackColor = Color.Green;
                        bt.ForeColor = Color.White;
                        break;
                    case "Phòng dơ":
                        bt.Appearance.BackColor = Color.Gray;
                        bt.Appearance.ForeColor = Color.Black;
                        break;
                    case "Phòng hỏng":
                        bt.Appearance.BackColor = Color.Red;
                        bt.Appearance.ForeColor = Color.White;
                        break;
                }
                panelControl2.Controls.Add(bt);
            }
        }

        private void Bt_Click(object sender, EventArgs e)
        {
            try
            {
                maPhong = int.Parse(((DropDownButton)sender).Name);
                lbl_TenPhong.Text = ((DropDownButton)sender).Tag + "";
                lbl_LoaiPhong.Text = (from w in Global.db.proc_LayThongTinPhong(maPhong) select w.TenLoaiPhong).FirstOrDefault() + "";
                lbl_NguoiTao.Text = (from w in Global.db.tbl_Phongs where w.MaPhong == maPhong select w.UserTao).FirstOrDefault();
                lbl_TinhTrang.Text = (from w in Global.db.tbl_Phongs where w.MaPhong == maPhong select w.TinhTrang).FirstOrDefault();
                lbl_Gia.Text = (from w in Global.db.proc_LayThongTinPhong(maPhong) select w.DonGia).FirstOrDefault() + "";
                switch (lbl_TinhTrang.Text)
                {
                    case "Sẵn sàng":
                        btn_DatPhong.Enabled = true;
                        btn_DatPhong.Text = "Đặt phòng";
                        break;
                    case "Khách đặt":
                        btn_DatPhong.Enabled = true;
                        btn_DatPhong.Text = "Thông tin phòng";
                        var thoigianden = (from w in Global.db.tbl_ThongTinDatPhongs where w.MaPhong == maPhong & w.Processed == 1 select w.NgayDen).FirstOrDefault();
                        var thoigiandi = (from w in Global.db.tbl_ThongTinDatPhongs where w.MaPhong == maPhong & w.Processed == 1 select w.NgayDi).FirstOrDefault();
                        lbl_ThoiGianThue.Text = "Thời gian: Từ " + thoigianden.Value.ToString("dd/MM/yyyy") + " đến " + thoigiandi.Value.ToString("dd/MM/yyyy");
                        var query = (from t1 in Global.db.tbl_ThongTinDatPhongs
                                     join t2 in Global.db.tbl_KhachHangs on t1.MaKhachHang equals t2.MaKhachHang
                                     select t2.TenKH).FirstOrDefault();
                        lbl_TenKH.Text = query;
                        break;
                    case "Có khách":
                        btn_DatPhong.Enabled = true;
                        btn_DatPhong.Text = "Thông tin phòng";

                        break;
                    case "Đến trong ngày":
                        btn_DatPhong.Enabled = true;
                        btn_DatPhong.Text = "Thông tin phòng";
                        break;
                    case "Chuẩn bị đi":
                        btn_DatPhong.Enabled = true;
                        btn_DatPhong.Text = "Thông tin phòng";
                        break;
                    case "Phòng dơ":
                        btn_DatPhong.Enabled = true;
                        btn_DatPhong.Text = "Thông tin phòng";
                        break;
                    case "Phòng hỏng":
                        btn_DatPhong.Enabled = false;
                        break;
                }
            }
            catch (Exception exception)
            {
                
            }
           
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}