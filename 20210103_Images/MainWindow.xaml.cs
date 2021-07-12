
using Microsoft.Win32;
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

namespace _20210103_Images
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bLoad_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            
            if (ofd.ShowDialog()==true)
            {
                Uri filePath = new Uri(ofd.FileName);
                iPic1.Source = new BitmapImage(filePath);
            }
        }

        private void bDefault_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmap = new BitmapImage(new Uri("resources/circle_64px.png", UriKind.Relative));
            iPic1.Source = bitmap;
        }
    }
}
