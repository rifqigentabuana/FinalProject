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
    /// Interaction logic for StatusPaketPage.xaml
    /// </summary>
    public partial class StatusPaketPage : Page
    {
        Controller.StatusController status;
        public StatusPaketPage()
        {
            InitializeComponent();
            status = new Controller.StatusController(this);
            status.penggunaan(); status.senin(); status.selasa(); status.rabu(); status.kamis();
            status.download();status.upload();
        }
    }
}
