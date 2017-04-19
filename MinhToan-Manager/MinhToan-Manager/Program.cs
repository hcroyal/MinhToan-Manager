using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using MinhToan_Manager.MyForm;

namespace MinhToan_Manager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            if (!SingleInstance.Start())
            {
                SingleInstance.ShowFirstInstance();
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();

            try
            {
                bool temp = false;
                do
                {
                    temp = false;
                    frm_Login frLogin = new frm_Login();

                    if (frLogin.ShowDialog() == DialogResult.OK)
                    {
                        frm_Main frMain = new frm_Main();

                        if (frMain.ShowDialog() == DialogResult.Yes)
                        {
                            frMain.Close();
                            temp = true;
                        }
                    }
                }
                while (temp);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            SingleInstance.Stop();
        }
    }
}
