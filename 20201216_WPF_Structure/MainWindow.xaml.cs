using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace _20201216_WPF_Structure
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //访问窗口中的资源,注意要在窗口加载后使用，要不无效
            Console.WriteLine(FindResource("sTest01").ToString());
            //访问全局资源
            Console.WriteLine(Application.Current.FindResource("Public123").ToString());

            //culture info
            CultureInfo usCulture = new CultureInfo("en-US");
            CultureInfo deCulture = new CultureInfo("de-DE");
            CultureInfo seCulture = new CultureInfo("sv-SE");

            l1.Content = DateTime.Now.ToString(usCulture);
            l2.Content = DateTime.Now.ToString(deCulture);
            l3.Content = DateTime.Now.ToString(seCulture);

        }
    }
}
