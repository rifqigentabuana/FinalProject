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
    /// Interaction logic for PaketTersediaPage.xaml
    /// </summary>
    public partial class PaketTersediaPage : Page
    {
        public PaketTersediaPage()
        {
            InitializeComponent();
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            lblHargaPaket.Content = "100.000";
        }

        private void StackPanel_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            lblHargaPaket.Content = "300.000";
        }

        private void StackPanel_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            lblHargaPaket.Content = "400.000";
        }

        private void StackPanel_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            lblHargaPaket.Content = "500.000";
        }

        private void btwBayar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Paket Telah Berhasil ditambahkan ke Pesnan Silahkan cek menu Pesanan/Silahkan Hubungi Customer Service kami untuk penanganan lebih lanjut");
        }
    }
}
