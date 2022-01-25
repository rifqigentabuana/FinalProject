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
    /// Interaction logic for CekTagihanPage.xaml
    /// </summary>
    public partial class CekTagihanPage : Page
    {
        Controller.TagihanController tagihan;

        public static string id;
        public static string abnoment;
        public static string tanggal;
        public static string lokal;
        public static string sljj;
        public static string percakapan_ponsel;
        public static string wifi;
        public static string diskon;
        public static string pajak;
        public CekTagihanPage()
        {
            InitializeComponent();
            tagihan = new Controller.TagihanController(this);
            lblUser.Content = Model.ModelPengguna.userName;
            lblNoID.Content = Model.ModelPengguna.userID;
            tagihan.cekTagihan();
            
        }
        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string data { get; set; }
        }
        private void F2_UpdateEventHandler(object sender, CekTagihanPage.UpdateEventArgs args)
        {
            tagihan.cekTagihan();
        }

        private void btwBayar_Click(object sender, RoutedEventArgs e)
        {
            tagihan.resetTagihan();
            CekTagihanPage cek = new CekTagihanPage();
            cek.UpdateEventHandler += F2_UpdateEventHandler;
            
            MessageBox.Show("Tagihan Berhasil Dibayar !");
        }
    }
}
