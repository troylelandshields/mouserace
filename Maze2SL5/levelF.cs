using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Maze2SL5
{
    public static class levelF
    {
        static Page lvl;

        public static void setPage(Page l)
        {
            lvl = l;
        }

        public static void getTime()
        {
            System.Windows.Threading.DispatcherTimer t = new System.Windows.Threading.DispatcherTimer();
            t.Interval = new TimeSpan(0, 0, 0, 0, 500); // 1000 Milliseconds 
            t.Tick += new EventHandler(setTime);
            t.Start();
        }
        public static void setTime(object sender, EventArgs e)
        {
            TextBlock timer = (TextBlock)lvl.FindName("timer");
            timer.Text = "Total Time: " + App.getTime().ToString();
        }

    }
}
