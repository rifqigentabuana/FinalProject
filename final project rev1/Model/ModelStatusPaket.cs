using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace final_project_rev1.Model
{
    class ModelStatusPaket
    {
        ModelTemplate temp;

        public string ID_Pengguna { get; set; }
       

        public ModelStatusPaket()
        {
            temp = new ModelTemplate();
        }

        
        public DataSet usage(string ID_Pengguna)
        {
            DataSet ds = new DataSet();
            ds = temp.SelectData("Select total_hari_ini from Penggunaan where ID_Pengguna='" + ID_Pengguna + "'", "Penggunaan");
            return ds;
        }
        public DataSet har_senin(string ID_Pengguna)
        {
            DataSet ds = new DataSet();
            ds = temp.SelectData("Select hari_senin from Penggunaan where ID_Pengguna='" + ID_Pengguna + "'", "Penggunaan");
            return ds;
        }
        public DataSet har_selasa(string ID_Pengguna)
        {
            DataSet ds = new DataSet();
            ds = temp.SelectData("Select hari_selasa from Penggunaan where ID_Pengguna='" + ID_Pengguna + "'", "Penggunaan");
            return ds;
        }
        public DataSet har_rabu(string ID_Pengguna)
        {
            DataSet ds = new DataSet();
            ds = temp.SelectData("Select hari_rabu from Penggunaan where ID_Pengguna='" + ID_Pengguna + "'", "Penggunaan");
            return ds;
        }
        public DataSet har_kamis(string ID_Pengguna)
        {
            DataSet ds = new DataSet();
            ds = temp.SelectData("Select hari_kamis from Penggunaan where ID_Pengguna='" + ID_Pengguna + "'", "Penggunaan");
            return ds;
        }
        public DataSet dow(string ID_Pengguna)
        {
           
            DataSet ds = new DataSet();
            ds = temp.SelectData("SELECT j.download FROM Jenis_Paket j JOIN Penggunaan P ON j.Jenis = p.paket_diambil WHERE p.ID_Pengguna = '" + ID_Pengguna + "'", "Penggunaan");
            
            return ds;
        }
        public DataSet up(string ID_Pengguna)
        {
           
            DataSet ds = new DataSet();
            ds = temp.SelectData("SELECT j.upload FROM Jenis_Paket j JOIN Penggunaan P ON j.Jenis = p.paket_diambil WHERE p.ID_Pengguna = '" + ID_Pengguna + "'", "Penggunaan");
           
            return ds;
        }
    }
}
