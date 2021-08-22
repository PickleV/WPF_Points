using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace _20210711_SwapWindows
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {

        private ViewModelBase _currentPage; //Current page

        public ViewModelBase CurrentPage
        {
            get { return _currentPage; }
            set { _currentPage = value; RaisePropertyChanged(() => CurrentPage); }
        }


        public RelayCommand HomeCommand { get; set; }
        public void HomeAction()
        {
            if (ClassPublic.vmHome==null)
            {
                ClassPublic.vmHome = new PageHomeViewModel();
            }
            CurrentPage = ClassPublic.vmHome;
        }

        public RelayCommand WorkCommand { get; set; }
        public void WorkAction()
        {
            if (ClassPublic.vmWork == null)
            {
                ClassPublic.vmWork = new PageWorkViewModel();
            }
            CurrentPage = ClassPublic.vmWork;
        }
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
            ///
            HomeCommand = new RelayCommand(HomeAction);
            WorkCommand = new RelayCommand(WorkAction);
        }
    }
}