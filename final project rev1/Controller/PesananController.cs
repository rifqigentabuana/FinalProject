using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows;

namespace final_project_rev1.Controller
{
    class PesananController
    {
        View.PesananPage view;
        Model.ModelPaket model;

        public PesananController(View.PesananPage view)
        {
            this.view = view;
            this.model = new Model.ModelPaket();
        }

        public void setData()
        {
            model.id = Model.ModelPengguna.userID;
            DataSet ds = model.getPesanan();
            view.dgPesanan.ItemsSource = ds.Tables[0].DefaultView;
        }

        public void HapusPesanan()
        {
            model.paket = View.PesananPage.paket;
            bool result = model.DeletePesanan();
            if (result)
            {
                MessageBox.Show("Data Pesanan berhasil dihapus");
            }
            else
            {
                MessageBox.Show("Maaf, gagal menghapus data pesanan");
            }
        }
    }
}
