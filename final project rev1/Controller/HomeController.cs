using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace final_project_rev1.Controller
{
    class HomeController
    {
        Model.ModelHome modhom;
        View.HomeMenuPage home;

        public HomeController(View.HomeMenuPage home)
        {
            modhom = new Model.ModelHome();
            this.home = home;
        }

        public void pengguna()
        {
            home.lblHallo.Content = "Hallo " + Model.ModelPengguna.userName;
            home.lbluserrr.Content = Model.ModelPengguna.userName;
        }
        public void paket_diambil()
        {
            string id = Model.ModelPengguna.userID;
            DataSet data = modhom.pak_saya(id);
            home.lblPktSaya.Content = data.Tables[0].Rows[0][0].ToString() + " Mbps";
        }
        public void paket_bulan()
        {
            string id = Model.ModelPengguna.userID;
            DataSet data = modhom.bulan(id);
            home.lblJanuari.Content = data.Tables[0].Rows[0][0].ToString();
            home.lblFebruari.Content = data.Tables[0].Rows[0][1].ToString();
            home.lblMaret.Content = data.Tables[0].Rows[0][2].ToString();
            home.lblApril.Content = data.Tables[0].Rows[0][3].ToString();
        }
    }
}
