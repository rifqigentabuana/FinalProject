using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace final_project_rev1.Controller
{
    class PenggunaController
    {
        Model.ModelPengguna pengguna;
        View.LoginWindows login;
        View.EditWindows edit;
        View.InformasiAkunPage informa;

        public PenggunaController(View.LoginWindows login)
        {
            pengguna = new Model.ModelPengguna();
            this.login = login;
        }

        View.RegisterWindows register;

        public PenggunaController(View.RegisterWindows register)
        {
            pengguna = new Model.ModelPengguna();
            this.register = register;
        }
        

        public void Login()
        {
            pengguna.id = login.txtUsername.Text;
            pengguna.password = login.txtPassword.Password;
            bool result = pengguna.CekLogin();
            if(result)
            {
                View.MenuUtama menu = new View.MenuUtama();
                menu.lblUser.Content = Model.ModelPengguna.userID;
                menu.Show();
                login.Close();

            }
            else
            {
                MessageBox.Show("Username/Password tidak dikenali/invalid !");
                login.txtUsername.Text = " ";
                login.txtPassword.Password = " ";
                login.txtUsername.Focus();
            }
        }

        public void Register()
        {
            pengguna.id = register.txtId.Text;
            pengguna.nama = register.txtNamaLengkap.Text;
            if (register.rdbLaki.IsChecked == true)
            {
                pengguna.gender = "L";
            }
            else
            {
                pengguna.gender = "P";
            }
            pengguna.tgl_Lahir = register.dtpTgl_Lahir.SelectedDate.Value.ToString("yyyy-MM-dd");
            pengguna.alamat = register.txtAlamat.Text;
            pengguna.no_telp = register.txtNoTelp.Text;
            pengguna.email = register.txtEmail.Text;
            pengguna.password = register.txtPassword.Text;

            bool result = pengguna.InsertPengguna();
            if(result)
            {
                MessageBox.Show("Berhasil Membuat Akun ! " +
                                "Silahkan mengunjungi/menghubungi customer service terdekat untuk menambahkan/memasang Wi-Fi");
                View.LoginWindows login = new View.LoginWindows();
                login.Show();
                register.Close();
            }
            else
            {
                MessageBox.Show("Maaf, Registrasi Akun baru Anda gagal, " +
                                "Silahkan Periksa kembali dan lengkapi data Anda");
            }
        }
        /*
        public void UbahData()
        {
            pengguna.nama = edit.txtNama.Text;            
            pengguna.tgl_Lahir = edit.dtptanggal.SelectedDate.Value.ToString("yyyy-MM-dd");
            pengguna.alamat = edit.txtAlamat.Text;
            pengguna.no_telp = edit.txtNomor.Text;
            pengguna.email = edit.txtEmail.Text;
            bool result = pengguna.UpdateUser();
            //bool result2 = pengguna.UpdateUser1();
            if (result)
            {
                    MessageBox.Show("Data siswa berhasil diubah");
                    edit.Close();
                    View.InformasiAkunPage informa = new View.InformasiAkunPage();
            }
            else
            {
                MessageBox.Show("Maaf, perubahan data siswa tidak dapat dilakukan, cek kembali dan pastikan data lengkap");
            }
        }
        */

    }
}
