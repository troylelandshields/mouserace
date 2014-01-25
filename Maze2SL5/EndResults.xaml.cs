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
using System.Windows.Navigation;
using Maze2SL5.ServiceReferenceDB;

namespace Maze2SL5
{
    public partial class EndResults : Level101
    {
        static List<clsRace> data;
        ServiceDBClient servicedbclient = new ServiceDBClient();

        public EndResults()
        {
            InitializeComponent();
            timer.Text = App.getTime().ToString();
            levelF.setPage(this);
            levelF.getTime();
            prev = "End";
            curr = "End";
            next = "End";
            addLevelNum();

            if (App.hashgroup.Length <= 0)
            {
                servicedbclient.getRacesCompleted += new EventHandler<getRacesCompletedEventArgs>(onComplete);
                servicedbclient.getRacesAsync();
            }
            else
            {
                servicedbclient.getHashRacesCompleted += new EventHandler<getHashRacesCompletedEventArgs>(onComplete2);
                servicedbclient.getHashRacesAsync(App.hashgroup);
            }
        }

        public void onComplete(object sender, ServiceReferenceDB.getRacesCompletedEventArgs e){
            data = e.Result;
            DataGrid1.ItemsSource = data;
        }

        public void onComplete2(object sender, ServiceReferenceDB.getHashRacesCompletedEventArgs e)
        {
            data = e.Result;
            DataGrid1.ItemsSource = data;
            hashlabel.Content = "#" + App.hashgroup;
        }

        public List<String> addIndex(int x)
        {
            List<String> l = new List<String>();
            for (int i = 1; i <= x; i++)
            {
                l.Add(i.ToString());
            }
            return l;
        }

        //private void setData()
        //{
        //    DataGrid1.ItemsSource = data;
        //}

        //void DisplayResults(object sender, getCustomerCompletedEventArgs e)
        //{
        //    LayoutRoot.DataContext = e.Result;
        //}

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        #region
        new protected void EnterWall(object sender, MouseEventArgs e)
        {
            //Level101.EnterWall(sender, e);
        }

        new protected void Up_Click(object sender, RoutedEventArgs e)
        {
            Level101.Up_Click(sender, e);
        }

        new protected void EndGame(object sender, RoutedEventArgs e)
        {
            Level101.EndGame(sender, e);
            //LayoutRoot.Children.Add(new EndGameDialog(App.getTime()));
            End.Visibility = Visibility.Collapsed;
            DataGrid1.Visibility = Visibility.Visible;
            hashlabel.Visibility = Visibility.Visible;
            Refresh.Visibility = Visibility.Visible;

            clsRace r = new clsRace()
            {
                Maze_Computer = App.computer,
                Maze_MaxLevel = App.maxlevel,
                Maze_Mouse = App.mouse,
                Maze_Name = App.name,
                Maze_OS = App.os,
                Maze_Time = App.getTime()
            };

            if (App.hashgroup.Length > 0)
            {
                r.Maze_HashGroup = App.hashgroup;
            }


            servicedbclient.addRaceAsync(r);
        }

        public override void addLevelNum()
        {
            base.addLevelNum();
            Thickness thick = new Thickness(219, 331, 0, -23);
            levelNum.Margin = thick;
            this.LayoutRoot.Children.Add(levelNum);
        }
        #endregion

        private void End_Click(object sender, RoutedEventArgs e)
        {
            EndGame(sender, e);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (App.hashgroup.Length > 0)
            {
                servicedbclient.getHashRacesCompleted += new EventHandler<getHashRacesCompletedEventArgs>(onComplete2);
                servicedbclient.getHashRacesAsync(App.hashgroup);
            }
            else
            {
                servicedbclient.getRacesCompleted += new EventHandler<getRacesCompletedEventArgs>(onComplete);
                servicedbclient.getRacesAsync();
            }
        }

    }
}
