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

namespace _20210201_DialogBox
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
            MessageBox.Show("This is a Test","Title");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result=MessageBox.Show("This is a Test 2", "Title",MessageBoxButton.YesNoCancel,MessageBoxImage.Question);
            switch (result)
            {
                case MessageBoxResult.None:
                    MessageBox.Show("None");
                    break;
                case MessageBoxResult.OK:
                    MessageBox.Show("OK");
                    break;
                case MessageBoxResult.Cancel:
                    MessageBox.Show("Cancel");
                    break;
                case MessageBoxResult.Yes:
                    MessageBox.Show("Yes");
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("No");
                    break;
                default:
                    break;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            InputWindow winInput = new InputWindow();
            bool? result = winInput.ShowDialog();

            if (result==true)
            {
                MessageBox.Show("Result OK");
            }
            else
            {
                MessageBox.Show("Not True");
            }
        }
    }
}
