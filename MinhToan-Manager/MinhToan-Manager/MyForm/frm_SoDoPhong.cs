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
            MessageBox.Show("Đặt phòng!");}
    }
}