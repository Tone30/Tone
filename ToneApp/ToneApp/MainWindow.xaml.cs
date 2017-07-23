using System.Windows;

namespace ToneApp
{
    /// <summary>
    ///     MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("OK");
        }


        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            string str = $"sss{0}code";

            this.Title = "注册号" + str;

            MessageBox.Show("注册不成功");
        }
    }
}