using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows;

namespace final_project_rev1.Controller
{
    class TagihanController
    {
        private Model.ModelTagihan tag;
        private View.CekTagihanPage han;

        public TagihanController(View.CekTagihanPage han)
        {
            tag = new Model.ModelTagihan();
            this.han = han;
        }

        public void cekTagihan()
        {
            //string tanggal = DateTime.Now.ToString("yyyy-mm-dd");
            string id = Model.ModelPengguna.userID;
            DataSet ds = tag.tagihan(id);
            han.lblAbnoment.Content = ds.Tables[0].Rows[0][0].ToString();
            han.lblLokal.Content = ds.Tables[0].Rows[0][1].ToString();
            han.lblSljj.Content = ds.Tables[0].Rows[0][2].ToString();
            han.lblPonsel.Content = ds.Tables[0].Rows[0][3].ToString();
            han.lblBiWifi.Content = ds.Tables[0].Rows[0][4].ToString();
            han.lblDiskon.Content = ds.Tables[0].Rows[0][5].ToString();
            han.lblPPN.Content = ds.Tables[0].Rows[0][6].ToString();
            han.lblTotal.Content = ds.Tables[0].Rows[0][7].ToString();
        }
        public void resetTagihan()
        {
            han.lblAbnoment.Content = 0;
            han.lblLokal.Content = 0;
            han.lblSljj.Content = 0;
            han.lblPonsel.Content = 0;
            han.lblBiWifi.Content = 0;
            han.lblDiskon.Content = 0;
            han.lblPPN.Content = 0;
            han.lblTotal.Content = 0;

            tag.ID_Pengguna = Model.ModelPengguna.userID;
            tag.UpdateTagihan();
        }
        public void tanggal()
        {
            string id = Model.ModelPengguna.userID;
            DataSet data = tag.tgl(id);
            han.lblPeriode.Content = data.Tables[0].Rows[0][0].ToString();
        }
    }
}
