using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace final_project_rev1.Model
{
    class ModelPengguna
    {
        ModelTemplate temp;
        
        public string id { get; set; }
        public string nama { get; set; }
        public string gender { get; set; }
        public string no_telp { get; set; }
        public string password { get; set; }
        public string alamat { get; set; }
        public string tgl_Lahir { get; set; }
        public string email { get; set; }

        public static string userName;
        public static string userID;

        public ModelPengguna()
        {
            temp = new ModelTemplate();
        }

        public Boolean CekLogin()
        {
            bool result;
            DataSet ds = new DataSet();
            ds = temp.Select("pengguna", "id = '" + id + "' AND password = '" + password + "'");

            if (ds.Tables[0].Rows.Count > 0)
            {
                result = true;
                userName = ds.Tables[0].Rows[0][1].ToString();
                userID = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                result = false;
            }
            return result;
        }

        public bool InsertPengguna()
        {
            string data = "'" + id + "','" + nama + "','" + gender + "','" + tgl_Lahir + "','" + alamat + "','" + no_telp + "','" + email + "','" + password + "'";
            return temp.Insert("pengguna", data);
        }
        
    }
}
