using DropdownMenu.ViewModel;
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
    /// UserControlBat.xaml 的交互逻辑
    /// </summary>
    public partial class UserControlBat : UserControl
    {
        public UserControlBat()
        {
            InitializeComponent();
            List<ServiceAndUserV0> list = new List<ServiceAndUserV0> { new ServiceAndUserV0 { services_id = "00555b29-e6c9-4155-8206-3695c6b22311", service_name = "APPSRV21", apply_souse = "", company = "江苏中煤电缆有限公司", english_abbreviation = "SP", position = "", name = "沈建强", phone = "13921381980", email = "sjq15312253367@126.com", open_date = "2022/9/21 0:00:00", close_date = "2022/9/21 0:00:00", account_number = "沈建强", use_name = "沈建强", start_password = "Sky123123sky", status = 1, user_describe = "", user_sign = 3, } };
            batuserListView.ItemsSource= list;

        }

        private void BasicRatingBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
