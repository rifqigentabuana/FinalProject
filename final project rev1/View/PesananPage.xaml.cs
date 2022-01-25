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
    /// Interaction logic for PesananPage.xaml
    /// </summary>
    public partial class PesananPage : Page
    {
        private Controller.PesananController controller;
        public PesananPage()
        {
            InitializeComponent();
            controller = new Controller.PesananController(this);

            controller.setData();
        }
        public static string paket;
        public static string harga;
        public void SetStaticVar()
        {
            paket = "";
            harga = "";
        }

        public void getData()
        {
            object item = dgPesanan.SelectedItem;
            paket = (dgPesanan.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
            harga = (dgPesanan.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
        }

        private void btnHapus_Click(object sender, RoutedEventArgs e)
        {
            object item = dgPesanan.SelectedItem;
            if (item == null)
            {
                MessageBox.Show("Pilih data pesanan yang ingin dihapus terlebih dahulu");
            }
            else
            {
                getData();
                if (MessageBox.Show("Yakin ingin menghapus data?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    controller.HapusPesanan();
                }
            }
            SetStaticVar();
            controller.setData();
        }

        private void btnBayar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Mohon maaf menu ini belum tersedia...");
        }
    }
}
