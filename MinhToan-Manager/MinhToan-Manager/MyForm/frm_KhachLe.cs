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
        public int maphong;
        public frm_KhachLe()
        {
            InitializeComponent();
        }

        private void btn_KhachDat_Click(object sender, EventArgs e)
        {
            var maphong = int.Parse((from w in Global.db.tbl_Phongs where w.TenPhong == lbl_ThongTinPhong.Text select w.MaPhong).FirstOrDefault()+"");

            Global.db.proc_DatPhong(txt_HoDem.Text, txt_Ten.Text, txt_SoDienThoai.Text, txt_DiaChiLienLac.Text,
                cbb_GioiTinh.Text, date_NgaySinh.DateTime, txt_CMTND.Text, txt_EmailLienLac.Text,
                Global.tenDangNhap, maphong, DateTime.Now, date_ngayden.DateTime, date_ngaydi.DateTime, "Đã đặt",
                txt_CongTy.Text, txt_NguoiLienHe.Text, txt_SDTLienHe.Text, txt_EmailNLH.Text, txt_ghichudatphong.Text,
                false, "", int.Parse(txt_TienDatCoc.Value + ""));
            MessageBox.Show("Đặt phòng thành công!");
            loadData();
            btn_KhachDat.Enabled = false;

        }

        private void loadData()
        {
           
            gridControl1.DataSource = Global.db.proc_LoadData(maphong);
          
        }

        private void frm_KhachLe_Load(object sender, EventArgs e)
        {
            maphong = int.Parse((from w in Global.db.tbl_Phongs where w.TenPhong == lbl_ThongTinPhong.Text select w.MaPhong).FirstOrDefault() + "");
            int maloaiphong = int.Parse((from w in Global.db.tbl_Phongs where w.MaPhong == maphong select w.MaLoaiPhong).FirstOrDefault() + "");
            txt_LoaiPhong.Text = (from w in Global.db.tbl_LoaiPhongs where w.MaLoaiPhong == maloaiphong select w.TenLoaiPhong).FirstOrDefault() + "";
            txt_TrangThai.Text = (from w in Global.db.tbl_Phongs where w.MaPhong == maphong select w.TinhTrang).FirstOrDefault() + "";
            txt_GiaPhong.Text = (from w in Global.db.tbl_LoaiPhongs where w.MaLoaiPhong == maloaiphong select w.DonGia).FirstOrDefault() + "";
            loadData();
            cbb_GioiTinh.SelectedIndex = 0;
            gridView1.OptionsBehavior.ReadOnly = true;
        }

        private void sửaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_CMTND.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CMTND") + "";
            string makh = (from w in Global.db.tbl_KhachHangs where w.CMTND == txt_CMTND.Text select w.MaKhachHang).FirstOrDefault() + "";
            txt_HoDem.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HoDemKH") + "";
            txt_Ten.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenKH") + "";
            cbb_GioiTinh.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GioiTinh") + "";
            date_NgaySinh.EditValue = DateTime.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NgaySinh") + "");
            txt_SoDienThoai.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SoDienThoai") + "";
            txt_EmailLienLac.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Email") + "";
            txt_DiaChiLienLac.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DiaChi") + "";
            date_ngayden.EditValue = DateTime.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NgayDen") + "");
            date_ngaydi.EditValue = DateTime.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NgayDi") + "");

            txt_MaDatPhong.Text = (from w in Global.db.tbl_ThongTinDatPhongs where w.MaKhachHang == int.Parse(makh) select w.MaDatPhong).FirstOrDefault() + "";
            txt_CongTy.Text = (from w in Global.db.tbl_ThongTinDatPhongs where w.MaKhachHang == int.Parse(makh) select w.CongTy).FirstOrDefault() + "";
            txt_NguoiLienHe.Text = (from w in Global.db.tbl_ThongTinDatPhongs where w.MaKhachHang == int.Parse(makh) select w.NguoiLienHe).FirstOrDefault() + "";
            txt_SDTLienHe.Text = (from w in Global.db.tbl_ThongTinDatPhongs where w.MaKhachHang == int.Parse(makh) select w.SoDienThoai).FirstOrDefault() + "";
            txt_EmailNLH.Text = (from w in Global.db.tbl_ThongTinDatPhongs where w.MaKhachHang == int.Parse(makh) select w.Email).FirstOrDefault() + "";
            txt_ghichudatphong.Text = (from w in Global.db.tbl_ThongTinDatPhongs where w.MaKhachHang == int.Parse(makh) select w.GhiChu).FirstOrDefault() + "";
            txt_TienDatCoc.Value = decimal.Parse((from w in Global.db.tbl_ThongTinDatPhongs where w.MaKhachHang == int.Parse(makh) select w.TienDatCoc).FirstOrDefault() + "");

            btn_LuuThongTin.Visible = true;

            
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //string cmtnd = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CMTND") + "";
            

        }

        private void btn_LuuThongTin_Click(object sender, EventArgs e)
        {
            string makh = (from w in Global.db.tbl_KhachHangs where w.CMTND == txt_CMTND.Text select w.MaKhachHang).FirstOrDefault() + "";
            Global.db.proc_UpdateThongTinDatPhong(int.Parse(makh), txt_HoDem.Text, txt_Ten.Text, txt_SoDienThoai.Text,
                txt_DiaChiLienLac.Text, cbb_GioiTinh.Text, date_NgaySinh.DateTime, txt_CMTND.Text,
                txt_EmailLienLac.Text, date_ngayden.DateTime, date_ngaydi.DateTime, txt_CongTy.Text,
                txt_NguoiLienHe.Text, txt_SDTLienHe.Text, txt_EmailNLH.Text,txt_ghichudatphong.Text,int.Parse(txt_TienDatCoc.Text),int.Parse(txt_MaDatPhong.Text));
            XtraMessageBox.Show("Bạn đã sửa thông tin thành công!");
            btn_LuuThongTin.Visible = false;
            loadData();
        }
    }
}