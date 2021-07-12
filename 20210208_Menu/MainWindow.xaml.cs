using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace _20210208_Menu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           // menuFile.FlowDirection = FlowDirection.RightToLeft;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void menuClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void menuOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter= "Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*";
            dialog.InitialDirectory = Directory.GetCurrentDirectory();
            dialog.Multiselect = true;
            if (dialog.ShowDialog()==true)
            {
                //Display single name
                tbResult.Text = dialog.FileName; //多选时显示第一个
                tbResult.Text += "\r\n---\r\n";

                //Display all names
                foreach (var item in dialog.FileNames)
                {
                    tbResult.Text += item + "\r\n";
                }

            }
        }

        private void menuSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog()==true)
            {
                StringBuilder builder = new StringBuilder();
                builder.AppendLine(dialog.FileName);
                builder.AppendLine("--------------------");
                tbResult.Text = builder.ToString();
                File.WriteAllText(dialog.FileName, builder.ToString(),Encoding.UTF8);
            }
            
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void cmdCut_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            tbResult.Text = "Cut!!!";
        }

        private void bContext_Click(object sender, RoutedEventArgs e)
        {
            bContext.ContextMenu.IsOpen = true;
        }

        private void bContext2_Click(object sender, RoutedEventArgs e)
        {
            //最简单写法
            cmButton1.PlacementTarget = (Button)sender;
            //ContextMenu context = bContext.ContextMenu; //从Button1取得contextMenu
            cmButton1.IsOpen = true;

            //查找context menu (注意要在资源文件中定义   <ContextMenu x:Key="cmContext">  )
            ContextMenu context = FindResource("cmContext") as ContextMenu;
            context.PlacementTarget = (Button)sender;
            context.IsOpen = true;
        }
    }
}
