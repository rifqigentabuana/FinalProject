using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows;

namespace final_project_rev1.Controller
{
    class InfoController
    {
        private Model.ModelInfo infor;
        private View.InformasiAkunPage masi;
        private View.EditWindows edit;

        public InfoController(View.InformasiAkunPage masi)
        {
            infor = new Model.ModelInfo();
            this.masi = masi;
        }

        public InfoController(View.EditWindows edit)
        {
            infor = new Model.ModelInfo();
            this.edit = edit;
        }
        public void informasi1()
        {
            string id = Model.ModelPengguna.userID;
            DataSet data = infor.infor1(id);
            masi.lblMember.Content = data.Tables[0].Rows[0][0].ToString();
            masi.lblUser1.Content = data.Tables[0].Rows[0][1].ToString();
            masi.lblGender.Content = data.Tables[0].Rows[0][2].ToString();
            masi.lblTTL.Content = data.Tables[0].Rows[0][3].ToString();
            masi.lblAlamat.Content = data.Tables[0].Rows[0][4].ToString();
            masi.lblNomor.Content = data.Tables[0].Rows[0][5].ToString();
            masi.lblEmail.Content = data.Tables[0].Rows[0][6].ToString();
            
        }

        public void UbahData()
        {
            infor.id = edit.lblMember.Content.ToString();
            infor.nama = edit.txtNama.Text;
            infor.tgl_Lahir = edit.dtptanggal.SelectedDate.Value.ToString("yyyy-MM-dd");
            infor.alamat = edit.txtAlamat.Text;
            infor.no_telp = edit.txtNomor.Text;
            infor.email = edit.txtEmail.Text;
            bool result = infor.UpdateUser();
            
            if (result)
            {
                MessageBox.Show("Data Pengguna berhasil diubah");
                edit.Close();
                View.InformasiAkunPage informa = new View.InformasiAkunPage();
            }
            else
            {
                MessageBox.Show("Maaf, perubahan data pengguna tidak dapat dilakukan, cek kembali dan pastikan data lengkap");
            }
        }

    }
}
