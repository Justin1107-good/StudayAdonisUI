using AdonisUI;
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

namespace StudayAdonisUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 添加姓名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddName_Click(object sender, RoutedEventArgs e)
        {

            //确保文本框包含名称。
            //验证文本框中输入的名称是否已经存在。
            //将名称添加到列表框。
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text))
            {
                lstNames.Items.Add(txtName.Text);
                txtName.Clear();
            }
            else
            {
                AdonisUI.Controls.MessageBox.Show("名称不能为空！", "Info", AdonisUI.Controls.MessageBoxButton.OKCancel, AdonisUI.Controls.MessageBoxImage.Information);
                //AdonisUI.Controls.MessageBox.Show("名称不能为空！");
                //MessageBox.Show("名称不能为空！");
                return;
            }
        }
             /// <summary>
             /// 修改试图色
             /// </summary>
             /// <param name="sender"></param>
             /// <param name="e"></param>
        private void button_CheckLight(object sender, RoutedEventArgs e)
        {
            if (btnChange.Content.ToString() == "☀")
            {
                AdonisUI.ResourceLocator.SetColorScheme(Application.Current.Resources, ResourceLocator.DarkColorScheme);
              
                btnChange.Content = "🌙";

            }
            else
            {
                AdonisUI.ResourceLocator.SetColorScheme(Application.Current.Resources, ResourceLocator.LightColorScheme);
                btnChange.Content = "☀";
            }


        }
    }
}
