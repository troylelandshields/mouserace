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
using System.Windows.Browser;


namespace Maze2SL5
{
    public partial class Level4 : Level101
    {
        public Level4()
        {
            InitializeComponent();
            timer.Text = App.getTime().ToString();
            levelF.setPage(this);
            levelF.getTime();
            prev = "Level3";
            next = "Level5";
            curr = "Level4";
            addLevelNum();
        }

        public override void setValues()
        {
            timer.Text = App.getTime().ToString();
            levelF.setPage(this);
            levelF.getTime();
            prev = "Level3";
            next = "Level5";
            curr = "Level4";
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
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
        }

        public override void addLevelNum()
        {
            base.addLevelNum();
            Thickness thick = new Thickness(219, 331, 0, -23);
            levelNum.Margin = thick;
            this.LayoutRoot.Children.Add(levelNum);
        }
        #endregion

        private void checked1(object sender, RoutedEventArgs e)
        {
            if (check1.IsChecked == true)
            {
                checkable1.Visibility = Visibility.Collapsed;
            }
            else
            {
                checkable1.Visibility = Visibility.Visible;
            }
        }

    }
}
