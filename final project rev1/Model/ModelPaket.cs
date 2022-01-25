using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows;

namespace final_project_rev1.Model
{
    class ModelPaket
    {
        public string id { get; set; }
        public string paket { get; set; }
        public int harga { get; set; }

        ModelTemplate model;

        public ModelPaket()
        {
            model = new ModelTemplate();
        }

        public bool pesan()
        {
            return model.Insert("Pesanan", "'" + id + "', '" + paket + "', " + harga);
        }

        public DataSet getPesanan()
        {
            return model.SelectData("SELECT paket, harga FROM Pesanan WHERE id = '" + id + "'", "Pesanan");
        }

        public bool DeletePesanan()
        {
            string tabel = "Pesanan";
            string kondisi = "paket='" + paket + "'";
            return model.Delete(tabel, kondisi);
        }
    }
}
