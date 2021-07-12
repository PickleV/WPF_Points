using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace _20201216_WPF_Structure
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //set application culture
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US"); //Set language
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("de-DE"); //set displayy style

            //Display启动命令
            string s = "";
            if (e.Args.Length > 0)
            {
                s = e.Args[0];
            }

            s = null;


        }

        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("An unhandled exception just occurred: " + e.Exception.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
            e.Handled = true; //mark it as handled
        }
    }
}
