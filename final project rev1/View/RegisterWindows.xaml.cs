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
    /// Interaction logic for RegisterWindows.xaml
    /// </summary>
    public partial class RegisterWindows : Window
    {
        Controller.PenggunaController pengguna;

        public RegisterWindows()
        {
            InitializeComponent();
            pengguna = new Controller.PenggunaController(this);
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            pengguna.Register();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            LoginWindows login = new LoginWindows();
            login.Show();
            this.Close();
        }
    }
}
