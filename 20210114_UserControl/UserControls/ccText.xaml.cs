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

namespace _20210114_UserControl.UserControls
{
    /// <summary>
    /// Interaction logic for ccText.xaml
    /// </summary>
    public partial class ccText : UserControl
    {
        public ccText()
        {
            InitializeComponent();
            this.DataContext = this; // 定义binding的内容为ccText本身, 不加的话binding中的属性无效
        }

        public string InputName { get; set; }
        public int InputMaxNum { get; set; }
    }
}
