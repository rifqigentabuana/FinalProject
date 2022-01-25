using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows;

namespace final_project_rev1.Model
{
    class ModelTagihan
    {
        ModelTemplate temp;

        public string ID_Pengguna { get; set; }
        public string tanggal { get; set; }
        public string abnoment { get; set; }
        public string lokal { get; set; }
        public string sljj { get; set; }
        public string percakapan_ponsel { get; set; }
        public string wifi { get; set; }
        public string diskon { get; set; }
        public string pajak { get; set; }
        public string total { get; set; }

        public ModelTagihan()
        {
            temp = new ModelTemplate();
        }
        public DataSet tagihan(string ID_Pengguna)
        {
            DataSet ds = new DataSet();
            ds = temp.SelectData("Select abnoment,lokal,sljj,percakapan_ponsel,wifi,diskon,pajak,total from Tagihan where ID_Pengguna='" + ID_Pengguna + "'", "Tagihan");
            return ds;
        }
        public DataSet tgl(string ID_Pengguna)
        {
            DataSet ds = new DataSet();
            ds = temp.SelectData("Select tanggal from Tagihan where ID_Pengguna='" + ID_Pengguna + "'", "Tagihan");
            return ds;
        }

        public bool UpdateTagihan()
        {
            MessageBox.Show(ID_Pengguna);
            string tabel = "Tagihan";
            string data = "abnoment = '0', lokal = '0', sljj = '0', percakapan_ponsel = '0', wifi= '0', pajak= '0', total = '0'";
            string kondisi = "ID_Pengguna = '" + ID_Pengguna + "'";
            return temp.Update(tabel, data, kondisi);
        }
    }
}
