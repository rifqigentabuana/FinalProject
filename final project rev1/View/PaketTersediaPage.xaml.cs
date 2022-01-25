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
        Controller.TersediaController controller;
        public PaketTersediaPage()
        {
            InitializeComponent();
            controller = new Controller.TersediaController(this);
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
           
            controller.paket1();
        }

        private void StackPanel_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            
            controller.paket2();
        }

        private void StackPanel_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            
            controller.paket3();
        }

        private void StackPanel_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            
            controller.paket4();
        }

        private void btwBayar_Click(object sender, RoutedEventArgs e)
        {
            controller.pesan();
        }
    }
}
