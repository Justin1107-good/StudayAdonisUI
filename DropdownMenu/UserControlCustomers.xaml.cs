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
        public UserControlCustomers()
        {
            InitializeComponent();
            RelodData();
        }
        public void RelodData()
        {
            List<TestModel> list = new List<TestModel> {
              new TestModel{  Code="M", Name="Material Design", Description="Material Design in xaml Toolkit", Options="Test"},
               new TestModel{  Code="F", Name="Material Design1", Description="Material Design in xaml Toolkit 1", Options="Test1"},
               new TestModel{  Code="MD", Name="Material Design2", Description="Material Design in xaml Toolkit 2", Options="Test2"}
              , new TestModel{  Code="H", Name="Material Design3", Description="Material Design in xaml Toolkit 3", Options="Test3"}
              , new TestModel{  Code="Y", Name="Material Design4", Description="Material Design in xaml Toolkit 4", Options="Test4"}
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
                        W
                        break;
                }
            }
        }
    }
}
