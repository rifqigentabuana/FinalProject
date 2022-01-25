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
using System.Data;

namespace final_project_rev1.View
{
    /// <summary>
    /// Interaction logic for EditWindows.xaml
    /// </summary>
    public partial class EditWindows : Window
    {
        private Controller.InfoController info;
        private Model.ModelInfo infor;
        
        public EditWindows()
        {
            InitializeComponent();
            info = new Controller.InfoController(this);
            lblMember.Content = InformasiAkunPage.id;
            txtNama.Text = InformasiAkunPage.nama;
            dtptanggal.SelectedDate = DateTime.Parse(InformasiAkunPage.tgl_Lahir);
            txtAlamat.Text = InformasiAkunPage.alamat;
            txtEmail.Text = InformasiAkunPage.email;
            txtNomor.Text = InformasiAkunPage.no_telp;
        }

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string data { get; set; }
        }

        private void btnsubmit_Click(object sender, RoutedEventArgs e)
        {
            info.UbahData();
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
            
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

       
    }
}
