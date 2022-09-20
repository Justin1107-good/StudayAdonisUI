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

namespace StudayAdonisUI
{
    /// <summary>
    /// ControlsUI.xaml 的交互逻辑
    /// </summary>
    public partial class ControlsUI : Window
    {
        public ControlsUI()
        {
            InitializeComponent();
        }

        private void btnAttribute(object sender, RoutedEventArgs e)
        {
            #region trim空异常    非常不友好
            //string s = null;
            //s.Trim();
            #endregion
            #region try catch异常
            //string s = null;
            //try
            //{
            //    s.Trim();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("刚刚发生了一个已处理的异常： " + ex.Message, "异常样本", MessageBoxButton.OK, MessageBoxImage.Warning);
            //}
            #endregion
            //  System.Diagnostics.Process.Start("windowsAttribute.html");

        }
    }
}
