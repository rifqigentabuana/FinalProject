using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace final_project_rev1.Model
{
    class ModelHome
    {
        ModelTemplate temp;
        public string ID_Pengguna { get; set; }
        public string paket_diambil { get; set; }

        public ModelHome()
        {
            temp = new ModelTemplate();
        }

        public DataSet pak_saya(string ID_Pengguna)
        {
            DataSet ds = new DataSet();
            ds = temp.SelectData("Select paket_diambil from Penggunaan where ID_Pengguna='" + ID_Pengguna + "'", "Penggunaan");
            return ds;
        }
        public DataSet bulan(string ID_Pengguna)
        {
            DataSet ds = new DataSet();
            ds = temp.SelectData("SELECT p.January,p.February,p.Maret,p.April FROM Penggunaan P JOIN  Pengguna pg ON p.ID_Pengguna = pg.id  WHERE pg.id = '" + ID_Pengguna + "'", "Pengguna");
            return ds;
        }
    }
}
