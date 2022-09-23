using DropdownMenu.DB;
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
        private readonly SqlSugarHelper _sqlSugar;

        public MainWindow()
        {
            InitializeComponent(); 
            var menuRegister = new List<SubItem>();
             

            menuRegister.Add(new SubItem("用户列表",
                new UserControlCustomers()));
            menuRegister.Add(new SubItem("用户服务", new UserControlSerives()));
            menuRegister.Add(new SubItem("用户脚本",new UserControlBat())); 
            var item6 = new ItemMenu("用户管理", menuRegister, PackIconKind.Register);

            var menuSchedule = new List<SubItem>();
            menuSchedule.Add(new SubItem("操作日志",new UserControlLog()));
            menuSchedule.Add(new SubItem("其他",new UserControlOther())); 
            var item1 = new ItemMenu("日志管理", menuSchedule, PackIconKind.Schedule);

            var menuReports = new List<SubItem>();
            menuReports.Add(new SubItem("大屏展示", new UserControlOther()));
            menuReports.Add(new SubItem("关于", new UserControlOther())); 
            var item2 = new ItemMenu("数据报告", menuReports, PackIconKind.FileReport);
 

            var menuFinancial = new List<SubItem>();
            menuFinancial.Add(new SubItem("关于",new UserControlliteratures()));
            menuFinancial.Add(new SubItem("版权", new UserControlOther()));
            var item4 = new ItemMenu("设置", menuFinancial, PackIconKind.ScaleBalance);

            
            Menu.Children.Add(new UserControlMenuItem(item6, this));
            Menu.Children.Add(new UserControlMenuItem(item1, this));
            Menu.Children.Add(new UserControlMenuItem(item2, this)); 
            Menu.Children.Add(new UserControlMenuItem(item4, this));

            SqlSugarHelper sqlSugar = new SqlSugarHelper();
            sqlSugar.InintialDB();
        }
        public MainWindow(SqlSugarHelper sqlSugar) {
            if (_sqlSugar==null)
            {
                _sqlSugar = new SqlSugarHelper();
            }
            _sqlSugar=sqlSugar;
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

        private void settinglistitem_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
