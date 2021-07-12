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

namespace _20210129_Commands
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel();
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Test01");
        }


        //WPF扫描线程来确诊是不是可以运行
        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandBinding_Executed_1(object sender, ExecutedRoutedEventArgs e)
        {
            //Environment.Exit(0);
            Application.Current.Shutdown();
        }


        private void CommandTestExecute(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Test in Test!");
            e.Handled = true; //State
        }
    }

    //自定义命令
    public static class CustomCommands
    {
        public static readonly RoutedUICommand Exit = new RoutedUICommand(
            "Exit", "Exit", typeof(CustomCommands),
            new InputGestureCollection()
            {
                //  new KeyGesture(Key.F4,ModifierKeys.Alt)  //hot key             
            }
            );

        //更多自定义命令---
        public static readonly RoutedUICommand Test01 = new RoutedUICommand("Test01", "Test01", typeof(CustomCommands));

        //    public static readonly RoutedUICommand Test01 = new RoutedUICommand(
        //"Test01", "Test01", typeof(CustomCommands),
        //new InputGestureCollection()
        //{
        //            //  new KeyGesture(Key.F4,ModifierKeys.Alt)  //hot key             
        //        }
        //);
    }

    public class MainViewModel
    {
        public static readonly RoutedUICommand cmd01 = new RoutedUICommand("Test01", "Test01", typeof(CustomCommands));
        public string Test02 { get; set; }

        public void Haha(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("haha");
            e.Handled = true; //State

        }
  

        public MainViewModel()
        {
            Test02 = "123456789";
        }



        //Self defined command easy to work with
        private ICommand _clickCommand;
        public ICommand ClickCommand
        { get { return _clickCommand ?? (_clickCommand = new CommandHandler(() => ClickCommand_Action(), true)); } }


        private ICommand _cmdTest03;

        public ICommand CMDTest03
        {
            get { return _cmdTest03??(_cmdTest03=new CommandHandler(()=> ClickCommand_Action(),true)); }
        }


        public void ClickCommand_Action()
        {
            //Do sth
            MessageBox.Show("haha");
        }
    }


    public class CommandHandler : ICommand
    {
        public event EventHandler CanExecuteChanged; //Event Must have 
        private Action _action;
        private bool _canExecute;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="action"></param>
        /// <param name="canExecute"></param>
        public CommandHandler(Action action, bool canExecute)
        {
            _action = action;
            _canExecute = canExecute;
        }

        //Define CanExecute interface
        public bool CanExecute(object parameter)
        {
            return _canExecute;
        }

        //Deine Execute interface
        public void Execute(object parameter)
        {
            _action();
        }
    }

}
