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

namespace Maze2SL5
{
    public partial class Level7 : Level101
    {
        public Level7()
        {
            InitializeComponent();
            timer.Text = App.getTime().ToString();
            levelF.setPage(this);
            levelF.getTime();
            prev = "Level6";
            next = "Level8";
            curr = "Level7";
            addLevelNum();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        public override void setValues()
        {
            timer.Text = App.getTime().ToString();
            levelF.setPage(this);
            levelF.getTime();
            prev = "Level6";
            next = "Level8";
            curr = "Level7";
        }

        #region
        new protected void EnterWall(object sender, MouseEventArgs e)
        {
            Level101.EnterWall(sender, e);
        }

        new protected void Up_Click(object sender, RoutedEventArgs e)
        {
            Level101.Up_Click(sender, e);
        }

        new protected void EndGame(object sender, RoutedEventArgs e)
        {
            Level101.EndGame(sender, e);
            LayoutRoot.Children.Add(new EndGameDialog(App.getTime()));
        }
        public override void addLevelNum()
        {
            base.addLevelNum();
            Thickness thick = new Thickness(219, 331, 0, -23);
            levelNum.Margin = thick;
            this.LayoutRoot.Children.Add(levelNum);
        }
        #endregion

        private void CheckBox_Click_1(object sender, RoutedEventArgs e)
        {
            if (key1.IsChecked == true)
            {
                door1.Visibility = Visibility.Collapsed;
                door1b.Visibility = Visibility.Collapsed;
            }
            else
            {
                door1.Visibility = Visibility.Visible;
                door1b.Visibility = Visibility.Visible;
            }
        }

        private void CheckBox_Click_2(object sender, RoutedEventArgs e)
        {
            if (key2.IsChecked == true)
            {
                door2.Visibility = Visibility.Collapsed;
                door2b.Visibility = Visibility.Collapsed;
            }
            else
            {
                door2.Visibility = Visibility.Visible;
                door2b.Visibility = Visibility.Visible;
            }
        }

        private void CheckBox_Click_3(object sender, RoutedEventArgs e)
        {
            if (key3.IsChecked == true)
            {
                door3.Visibility = Visibility.Collapsed;
                label_Copy31.Visibility = Visibility.Collapsed;
            }
            else
            {
                door3.Visibility = Visibility.Visible;
                label_Copy31.Visibility = Visibility.Visible;
            }
        }


    }
}
