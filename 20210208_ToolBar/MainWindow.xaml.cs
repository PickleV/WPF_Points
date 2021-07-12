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
using System.Diagnostics;

namespace _20210208_ToolBar
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

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
    



        }

        private void TextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            //Get textbox
            TextBox textBox = (TextBox)sender;

            int row = textBox.GetLineIndexFromCharacterIndex(textBox.CaretIndex);
            int col= textBox.CaretIndex - textBox.GetCharacterIndexFromLineIndex(row);
            int count = textBox.Text.Length;

            //Get textbox line/count
            StringBuilder builder = new StringBuilder();
            builder.Append("Row: "+(row+1)+" , ");
            builder.Append("Column: "+(col+1)+" , ");
            builder.Append("Count: " + count);

            //DisplayLine
            tbCount.Text = builder.ToString();

            Debug.WriteLine("Info:" + textBox.GetCharacterIndexFromLineIndex(row));
        }
    }
}
