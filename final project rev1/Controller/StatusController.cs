using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace final_project_rev1.Controller
{
    class StatusController
    {
        //declare
        Model.ModelStatusPaket status;
        View.StatusPaketPage paket;

        public StatusController(View.StatusPaketPage paket)
        {
            status = new Model.ModelStatusPaket();
            this.paket = paket;
        }

        public void penggunaan()
        {
            string id = Model.ModelPengguna.userID;
            DataSet data = status.usage(id);
            paket.lblpenggunaan.Content = data.Tables[0].Rows[0][0].ToString();
        }
        public void senin()
        {
            string id = Model.ModelPengguna.userID;
            DataSet data = status.har_senin(id);
            paket.lblsenin.Content = data.Tables[0].Rows[0][0].ToString();
        }
        public void selasa()
        {
            string id = Model.ModelPengguna.userID;
            DataSet data = status.har_selasa(id);
            paket.lblselasa.Content = data.Tables[0].Rows[0][0].ToString();
        }
        public void rabu()
        {
            string id = Model.ModelPengguna.userID;
            DataSet data = status.har_rabu(id);
            paket.lblrabu.Content = data.Tables[0].Rows[0][0].ToString();
        }
        public void kamis()
        {
            string id = Model.ModelPengguna.userID;
            DataSet data = status.har_kamis(id);
            paket.lblkamis.Content = data.Tables[0].Rows[0][0].ToString();
        }
        public void download()
        {
            string id = Model.ModelPengguna.userID;
            DataSet data = status.dow(id);
            paket.lblDownload.Content = data.Tables[0].Rows[0][0].ToString();
        }
        public void upload()
        {
            string id = Model.ModelPengguna.userID;
            DataSet data = status.up(id);
            paket.lblUpload.Content = data.Tables[0].Rows[0][0].ToString();
        }
    }
}
