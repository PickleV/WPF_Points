using DevExpress.Mvvm;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using _20210815_MultiModuleDisplay.ViewModel;

namespace _20210815_MultiModuleDisplay.Views
{
    /// <summary>
    /// Interaction logic for ControlStatus.xaml
    /// </summary>
    public partial class ControlModlueStatus : UserControl
    {
        public ControlModlueStatus()
        {
            InitializeComponent();
            DataContext = new ModuleVIewModel();


 
        }

     



    }


  
}
