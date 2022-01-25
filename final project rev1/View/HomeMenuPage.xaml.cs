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
    /// Interaction logic for HomeMenuPage.xaml
    /// </summary>
    public partial class HomeMenuPage : Page
    {
        Controller.HomeController home;
        public HomeMenuPage()
        {
            InitializeComponent();
            lblTanggal.Content = DateTime.Now.ToString("dddd, dd MMMM yyy");
            string JamIni = DateTime.Now.ToString("HH:mm");
            lblPukul.Content = JamIni;
            home = new Controller.HomeController(this);
            home.pengguna();home.paket_diambil();
            home.paket_bulan();
        }

        private void stackCekTagihan_MouseDown(object sender, MouseButtonEventArgs e)
        {
            View.MenuUtama menu = new View.MenuUtama();
            menu.frmMain.Navigate(new View.CekTagihanPage());
        }
    }
}
