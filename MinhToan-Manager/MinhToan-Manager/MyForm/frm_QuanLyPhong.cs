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
    public partial class frm_QuanLyPhong : DevExpress.XtraEditors.XtraForm
    {
        public frm_QuanLyPhong()
        {
            InitializeComponent();
        }

        private void frm_QuanLyPhong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var query = (from w in Global.db.tbl_Phongs select new {w.MaPhong, w.TenPhong, w.MaLoaiPhong}).ToList();
            gridControl1.DataSource = query;
            var dt = (from w in Global.db.tbl_LoaiPhongs select new {w.MaLoaiPhong, w.TenLoaiPhong, w.DonGia, w.GhiChu}).ToList();
            
          

        }
    }
}