using DropdownMenu.ViewModel;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); 
            var menuRegister = new List<SubItem>();
             

            menuRegister.Add(new SubItem("用户列表",
                new UserControlCustomers()));
            menuRegister.Add(new SubItem("用户服务", new UserControlProviders()));
            menuRegister.Add(new SubItem("用户维护")); 
            var item6 = new ItemMenu("用户管理", menuRegister, PackIconKind.Register);

            var menuSchedule = new List<SubItem>();
            menuSchedule.Add(new SubItem("操作日志"));
            menuSchedule.Add(new SubItem("其他")); 
            var item1 = new ItemMenu("日志管理", menuSchedule, PackIconKind.Schedule);

            var menuReports = new List<SubItem>();
            menuReports.Add(new SubItem("大屏展示"));
            menuReports.Add(new SubItem("关于")); 
            var item2 = new ItemMenu("数据报告", menuReports, PackIconKind.FileReport);
 

            var menuFinancial = new List<SubItem>();
            menuFinancial.Add(new SubItem("关于"));
            menuFinancial.Add(new SubItem("版权"));
            var item4 = new ItemMenu("设置", menuFinancial, PackIconKind.ScaleBalance);

            
            Menu.Children.Add(new UserControlMenuItem(item6, this));
            Menu.Children.Add(new UserControlMenuItem(item1, this));
            Menu.Children.Add(new UserControlMenuItem(item2, this)); 
            Menu.Children.Add(new UserControlMenuItem(item4, this));
        }
        internal void SwitchScreen(object sender)
        {
            var screen = ((UserControl)sender);
            if (screen != null)
            {
                StackPanelMain.Children.Clear();
                StackPanelMain.Children.Add(screen);
            }
        }
    }
}
