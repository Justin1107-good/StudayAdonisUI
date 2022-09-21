using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// UserControlliteratures.xaml 的交互逻辑
    /// </summary>
    public partial class UserControlliteratures : UserControl
    {
        public UserControlliteratures()
        {
            InitializeComponent();

            //Label linkLabel = new Label();
            //Run linkText = new Run("MaterialDesignInXamlToolkit");
            //Hyperlink link = new Hyperlink(linkText); 
            //link.NavigateUri = new Uri("https://github.com/MaterialDesignInXAML/MaterialDesignInXamlToolkit");
            //link.RequestNavigate += new RequestNavigateEventHandler(delegate (object sender, RequestNavigateEventArgs e) { 
            //    Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            //    e.Handled = true; 
            //}); 
            //linkLabel.Content = link; myStackPanel.Children.Add(linkLabel);  // 在Xaml中创建一个StackPanel控件 名字myStackPanel
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            //Hyperlink link = sender as Hyperlink; 
            //Process.Start(new ProcessStartInfo(link.NavigateUri.AbsoluteUri));
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
           
        }
    }
}
