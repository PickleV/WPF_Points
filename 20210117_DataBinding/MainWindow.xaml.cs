using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace _20210117_DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string sHAHA = "123456,Test!";


        List<string> l01 = new List<string>();

        public ObservableCollection<string> l02 = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s1 = Application.Current.FindResource("sTest01").ToString();
            string s2 = this.FindResource("sName01").ToString();
            MessageBox.Show(s1+"\r\n"+s2);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Binding bind = new Binding("Text"); //Text为属性
            bind.Source = tbInput; //Set source
            tbOutput.SetBinding(TextBox.TextProperty,bind); //Bind this binding
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(c1.Width.ToString());
            tbInput.Text += "---HAHA";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            l02.Add("test1");
            l02.Add("test2");
            lb01.ItemsSource = l02;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            l02.Add("Test:" + DateTime.Now.ToString());

        }
    }


   

}
