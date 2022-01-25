using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace final_project_rev1.Model
{
    class ModelInfo
    {
        ModelTemplate temp;

        public string id { get; set; }
        public string password { get; set; }
        public string nama { get; set; }
        public string tmpt_Lahir { get; set; }
        public string alamat { get; set; }
        public string gender { get; set; }
        public string no_telp { get; set; }
        public string tgl_Lahir { get; set; }
        public string status_akun { get; set; }
        public string email { get; set; }
       

        
        public ModelInfo()
        {
            temp = new ModelTemplate();
        }

        public DataSet infor1(string id)
        {
            DataSet ds = new DataSet();
            ds = temp.SelectData("Select id,nama,gender,tgl_Lahir,alamat,no_telp,email from Pengguna where id='" + id + "'", "Pengguna");
            return ds;
        }
        
        public bool UpdateUser()
        {
            string tabel = "Pengguna";
            string data = "nama = '" + nama + "', tgl_Lahir = '" + tgl_Lahir + "', alamat = '" + alamat + "', no_telp = '" + no_telp + "', email = '" + email + "'";
            string kondisi = "id='" + id + "'";
            return temp.Update(tabel, data, kondisi);
        }

    }
}
