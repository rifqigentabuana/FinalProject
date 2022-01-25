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
using System.Windows.Shapes;

namespace final_project_rev1.View
{
    /// <summary>
    /// Interaction logic for MenuUtama.xaml
    /// </summary>
    public partial class MenuUtama : Window
    {
        public MenuUtama()
        {
            InitializeComponent();

            //Model.ModelTemplate cek = new Model.ModelTemplate();
            
        }

        private void lblMenuHome_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new View.HomeMenuPage());
        }

        private void lblMenuTegihan_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new View.CekTagihanPage());
        }

        private void lblStatusPaket_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new View.StatusPaketPage());
        }

        private void lblMenuPaket_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new View.PaketTersediaPage());
        }

        private void lblMenuInfor_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new View.InformasiAkunPage());
        }

        private void lblMenuSyarat_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new View.SyaratPage());
        }

        private void lblMenuExit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void lblAkun_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new View.InformasiAkunPage());
        }

        private void lblLogOut_MouseDown(object sender, MouseButtonEventArgs e)
        {
            LoginWindows login = new LoginWindows();
            
            login.Show();
            this.Close();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
                if (MenuProfile.Visibility == Visibility.Visible)
                {
                    MenuProfile.Visibility = Visibility.Hidden;
                }
                else
                {
                    MenuProfile.Visibility = Visibility.Visible;
                }
            
        }

        private void lblMenuPesanan_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new View.PesananPage());
        }
    }
}
