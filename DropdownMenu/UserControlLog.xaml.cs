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
    /// UserControlLog.xaml 的交互逻辑
    /// </summary>
    public partial class UserControlLog : UserControl
    {
        public UserControlLog()
        {
            InitializeComponent();//logListView
            List<sky_LogInfo> sky_Logs = new List<sky_LogInfo>
            {
               new sky_LogInfo {  id=1, userName="超级管理员", MethodName="用户新增", OperationType="增加", paramsList="/112/rer/545//trt", errorMsg="", respDate=DateTime.Now, VisitDate=DateTime.Now, results="成功"},
               new sky_LogInfo {  id=3, userName="超级管理员", MethodName="用户新增", OperationType="增加", paramsList="/112/rer/545//trt", errorMsg="", respDate=DateTime.Now, VisitDate=DateTime.Now, results="成功"},
                new sky_LogInfo {  id=5, userName="超级管理员", MethodName="用户新增", OperationType="增加", paramsList="/112/rer/545//trt", errorMsg="", respDate=DateTime.Now, VisitDate=DateTime.Now, results="成功"}
            };
            logListView.ItemsSource = sky_Logs;
        }

        private void BasicRatingBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
