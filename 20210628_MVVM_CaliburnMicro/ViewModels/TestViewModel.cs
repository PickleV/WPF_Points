using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace _20210628_MVVM_CaliburnMicro
{
   public class TestViewModel: INotifyPropertyChanged  //Must have
    {
       
        public List<string> lValues { get; set; }

        private int _Test;  //Must be full property
        public int Test
        {
            get { return _Test; }
            set {

                _Test = value;
                RaisePropertyChange("Test");
               
            }
        }


        public event PropertyChangedEventHandler PropertyChanged; //Define property change event

        //Init value
        public TestViewModel()  
        {
            Test = 100;

            lValues = new List<string>() { "A","B","C"};
            
        }

        //Property change event to notice interface to rebind value
        public void RaisePropertyChange(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }

        //Define a command
        private ICommand _clickCommand;
        public ICommand ClickCommand
        {
            get
            {
                return _clickCommand??(_clickCommand = new CommandHandler(() => MyAction(), () => CanExecute));
            }
        }

        public bool CanExecute
        {
            get
            {
                // check if executing is allowed, i.e., validate, check if a process is running, etc. 
                return true;
            }
        }

        public void MyAction()
        {
            MessageBox.Show("This is a Test");
        }

    }

    public class CommandHandler : ICommand
    {
        private Action _action;
        private Func<bool> _canExecute;

        /// <summary>
        /// Creates instance of the command handler
        /// </summary>
        /// <param name="action">Action to be executed by the command</param>
        /// <param name="canExecute">A bolean property to containing current permissions to execute the command</param>
        public CommandHandler(Action action, Func<bool> canExecute)
        {
            _action = action;
            _canExecute = canExecute;
        }

        /// <summary>
        /// Wires CanExecuteChanged event 
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Forcess checking if execute is allowed
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return _canExecute.Invoke();
        }

        public void Execute(object parameter)
        {
            _action();
        }


    }
}
