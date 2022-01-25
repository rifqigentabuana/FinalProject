using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace final_project_rev1.Controller
{
    class TersediaController
    {
        View.PaketTersediaPage view;
        Model.ModelPaket model;
        public TersediaController(View.PaketTersediaPage view)
        {
            this.view = view;
            model = new Model.ModelPaket();
        }

        public void paket1()
        {
            model.paket = "10 Mbps";
            model.harga = 100000;
            view.lblHargaPaket.Content = "100.000";
        }

        public void paket2()
        {
            model.paket = "20 Mbps";
            model.harga = 300000;
            view.lblHargaPaket.Content = "300.000";
        }

        public void paket3()
        {
            model.paket = "30 Mbps";
            model.harga = 400000;
            view.lblHargaPaket.Content = "400.000";
        }

        public void paket4()
        {
            model.paket = "40 Mbps";
            model.harga = 500000;
            view.lblHargaPaket.Content = "500.000";
        }

        public void pesan()
        {
            model.id = Model.ModelPengguna.userID;
            bool res = model.pesan();

            if (res)
            {
                MessageBox.Show("Berhasil masuk ke dalam pesanan");
            }
            else
            {
                MessageBox.Show("Gagal memesan");
            }
        }
    }
}
