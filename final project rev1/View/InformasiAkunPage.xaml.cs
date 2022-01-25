using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace final_project_rev1.View
{
    /// <summary>
    /// Interaction logic for InformasiAkunPage.xaml
    /// </summary>
    public partial class InformasiAkunPage : Page
    {
        Controller.InfoController info;

        public static string id;
        public static string nama;
        public static string tgl_Lahir;
        public static string alamat;
        public static string email;
        public static string no_telp;
        public static string foto;

        public InformasiAkunPage()
        {
            InitializeComponent();
            info = new Controller.InfoController(this);
            info.informasi1();
        }
        public void SetStaticVar()
        {
            id = "";
            nama = "";
            tgl_Lahir = "";
            alamat = "";
            no_telp = "";
            email = "";
            foto = "";
        }
        public void getData()
        {
            id = lblMember.Content.ToString();
            nama = lblUser1.Content.ToString();
            tgl_Lahir = lblTTL.Content.ToString();
            alamat = lblAlamat.Content.ToString();
            email = lblEmail.Content.ToString();
            no_telp = lblNomor.Content.ToString();
            
        }
        private void F2_UpdateEventHandler(object sender, EditWindows.UpdateEventArgs args)
        {
            info.informasi1();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            getData();
            EditWindows edit = new EditWindows();
            edit.UpdateEventHandler += F2_UpdateEventHandler;
            edit.Show();
            SetStaticVar();
        }
    }
}
