using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Maze2SL5
{
    public partial class App : Application
    {
        private static Grid root;
        private static System.Windows.Threading.DispatcherTimer myDispatcherTimer;
        private static int i = 0;
        public static string os {get; set;}
        public static string mouse { get; set; }
        public static string computer { get; set; }
        public static string maxlevel { get; set; }
        public static string name { get; set; }
        public static string hashgroup { get; set; }

 
        public static void dbConnect(){
  
        }

        public App()
        {
            this.Startup += this.Application_Startup;
            this.Exit += this.Application_Exit;
            this.UnhandledException += this.Application_UnhandledException;

            InitializeComponent();
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            root = new Grid();
            root.Children.Add(new MainPage());

            this.RootVisual = root;
        }

        public static void StartTimer()
        {
            myDispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            myDispatcherTimer.Interval = new TimeSpan(0, 0, 0, 1, 0); // 1000 Milliseconds 
            myDispatcherTimer.Tick += new EventHandler(Each_Tick);
            myDispatcherTimer.Start();
        }

        public static void Each_Tick(object o, EventArgs sender)
        {
            i++;
        }

        public static int getTime()
        {
            return i;
        }

        public static void End_Click()
        {
            myDispatcherTimer.Stop();
        }

        public static UserControl Navigate(UserControl newPage)
        {
            UserControl oldPage = root.Children[0] as UserControl;

            root.Children.Add(newPage);
            root.Children.Remove(oldPage);

            return newPage;
        }

        private void Application_Exit(object sender, EventArgs e)
        {
        }

        private void Application_UnhandledException(object sender, ApplicationUnhandledExceptionEventArgs e)
        {
            // If the app is running outside of the debugger then report the exception using
            // the browser's exception mechanism. On IE this will display it a yellow alert 
            // icon in the status bar and Firefox will display a script error.
            if (!System.Diagnostics.Debugger.IsAttached)
            {

                // NOTE: This will allow the application to continue running after an exception has been thrown
                // but not handled. 
                // For production applications this error handling should be replaced with something that will 
                // report the error to the website and stop the application.
                e.Handled = true;
                Deployment.Current.Dispatcher.BeginInvoke(delegate { ReportErrorToDOM(e); });
            }
        }

        private void ReportErrorToDOM(ApplicationUnhandledExceptionEventArgs e)
        {
            try
            {
                string errorMsg = e.ExceptionObject.Message + e.ExceptionObject.StackTrace;
                errorMsg = errorMsg.Replace('"', '\'').Replace("\r\n", @"\n");

                System.Windows.Browser.HtmlPage.Window.Eval("throw new Error(\"Unhandled Error in Silverlight Application " + errorMsg + "\");");
            }
            catch (Exception)
            {
            }
        }
    }
}
