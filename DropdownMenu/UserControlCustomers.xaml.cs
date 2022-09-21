using DropdownMenu.DB;
using DropdownMenu.Model.DBEntity;
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
    /// UserControlCustomers.xaml 的交互逻辑
    /// </summary>
    public partial class UserControlCustomers : UserControl
    {
        SqlSugarHelper sqlSugar = new SqlSugarHelper();

        public UserControlCustomers()
        {
            InitializeComponent();
            RelodData();
        }
       
        public void RelodData()
        {
            List<ServiceAndUserV0> list = new List<ServiceAndUserV0> {
              new ServiceAndUserV0{
                services_id="00555b29-e6c9-4155-8206-3695c6b22311",
                 service_name="APPSRV21",
                  apply_souse="",
                   company="江苏中煤电缆有限公司",
                    english_abbreviation="SP",
                     position="",
                      name="沈建强",
                      phone="13921381980",
                      email="sjq15312253367@126.com",
                       open_date="2022/9/21 0:00:00",
                       close_date="2022/9/21 0:00:00",
                       account_number="沈建强",
                       use_name="沈建强",
                       start_password="Sky123123sky",
                       status=1,
                       user_describe="",
                       user_sign=3,

              }
            };
            accentListView.ItemsSource = list;
        }

        private void settinglistitem_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            //this.stencilListBox.AddHandler(UIElement.MouseDownEvent, new MouseButtonEventHandler(StencilMouseDown), true);
            //settinglistitem.AddHandler(UIElement.MouseDownEvent, new MouseButtonEventHandler(StencilMouseDown), true);
            var item = ItemsControl.ContainerFromElement(sender as ListBox, e.OriginalSource as DependencyObject) as ListBoxItem;
            if (item != null)
            {         // ListBox item clicked - do some cool things here    浅色 深色 退出  }
                switch (item.Content)
                {
                    case "浅色":
                        //AdonisUI.ResourceLocator.SetColorScheme(Application.Current.Resources, ResourceLocator.DarkColorScheme);
                        MaterialDesignColors.ColorManipulation.ColorAssist.IsDarkColor(Colors.LightBlue);
                        // _=     MaterialDesignThemes.Wpf.ColorZoneMode.SecondaryLight;   //MaterialDesignThemes.Wpf.ColorZoneMode.PrimaryLight;//= MaterialDesignColors.SecondaryColor.LightBlue;
                        break;
                    case "深色":
                        //_ = MaterialDesignThemes.Wpf.ColorZoneMode.SecondaryDark;
                        MaterialDesignColors.ColorManipulation.ColorAssist.IsLightColor(Colors.DarkBlue);
                        break;
                    case "退出":

                        break;
                }
            }
        }

        private void BasicRatingBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {

            sqlSugar.InintialDB();
            int h = sqlSugar.ExecuteInsert(new sky_application_service { service_name = "Test1", service_describe = "sqlsugar+sqlite insert data1", create_time = DateTime.Now.ToString("yyyyMMdd HH:ss:mm"), update_time = DateTime.Now.ToString("yyyyMMdd HH:ss:mm"), is_delete = 0, use_total = 30, use_opened_num = 25, use_surplus_num = 5 });
            if (h > 0)
            {
                Console.WriteLine("服务：Test创建成功！");
            }
            else
            {
                Console.WriteLine("服务：Test创建失败！");
            }
        }
    }
}
