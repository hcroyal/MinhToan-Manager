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
    public partial class frm_KhachLe : DevExpress.XtraEditors.XtraForm
    {
        public frm_KhachLe()
        {
            InitializeComponent();
        }

        private void btn_KhachDat_Click(object sender, EventArgs e)
        {
            var maphong = int.Parse((from w in Global.db.tbl_Phongs where w.TenPhong == lbl_ThongTinPhong.Text select w.MaPhong).FirstOrDefault()+"");

            Global.db.proc_DatPhong(txt_Dem.Text, txt_Ten.Text, txt_SoDienThoai.Text, txt_DiaChiLienLac.Text,
                cbb_GioiTinh.SelectedText, date_NgaySinh.DateTime, txt_CMTND.Text, txt_EmailLienLac.Text,
                Global.tenDangNhap, maphong, DateTime.Now, date_ngayden.DateTime, date_ngaydi.DateTime, "Đã đặt",
                txt_CongTy.Text, txt_NguoiLienHe.Text, txt_SDTLienHe.Text, txt_EmailNLH.Text, txt_ghichudatphong.Text,
                false, "", int.Parse(txt_TienDatCoc.Value + ""));
            MessageBox.Show("Đặt phòng thành công!");
            loadData();


        }

        private void loadData()
        {
            var maphong = int.Parse((from w in Global.db.tbl_Phongs where w.TenPhong == lbl_ThongTinPhong.Text select w.MaPhong).FirstOrDefault() + "");
            gridControl1.DataSource = Global.db.proc_LoadData(maphong);
        }

        private void frm_KhachLe_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}