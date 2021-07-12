using System.Windows;
using System.Windows.Input;

namespace _20201215_WPF_Hello
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

        private void gridMain_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("This is a test");
 
        }

        private void gridMain_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void gridMain_MouseEnter(object sender, MouseEventArgs e)
        {

        }
    }
}
