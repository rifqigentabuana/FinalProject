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
    /// Interaction logic for LoginWindows.xaml
    /// </summary>
    public partial class LoginWindows : Window
    {
        Controller.PenggunaController pengguna;

        public LoginWindows()
        {
            InitializeComponent();
            pengguna = new Controller.PenggunaController(this);
        }

        private void btwLogin_Click(object sender, RoutedEventArgs e)
        {
            pengguna.Login();
        }

        private void lblSignup_MouseDown(object sender, MouseButtonEventArgs e)
        {
            RegisterWindows register = new RegisterWindows();
            register.Show();
            this.Close();
        }
    }
}
