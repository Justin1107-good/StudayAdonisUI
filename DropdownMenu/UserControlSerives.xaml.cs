using DropdownMenu.Model.DBEntity;
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

namespace DropdownMenu
{
    /// <summary>
    /// UserControlSerives.xaml 的交互逻辑
    /// </summary>
    public partial class UserControlSerives : UserControl
    {
        public UserControlSerives()
        {
            InitializeComponent();
            List<sky_application_service> services = new List<sky_application_service> {
              new sky_application_service{ id=1, service_name="", service_describe="", create_time=DateTime.Now.ToString("yyyyMMdd HH:ss:dd"), update_time=DateTime.Now.ToString("yyyyMMdd HH:ss:dd"), use_total=30, use_opened_num=15, use_surplus_num=15 }
            };
            accentListservicesView.ItemsSource = services;
        }

        private void BasicRatingBar1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void btn_addservices_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
