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
    public partial class Level6 : Level101
    {
        public Level6()
        {
            InitializeComponent();
            timer.Text = App.getTime().ToString();
            levelF.setPage(this);
            levelF.getTime();
            prev = "Level5";
            next = "Level7";
            curr = "Level6";
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
            prev = "Level5";
            next = "Level7";
            curr = "Level6";
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

    }
}
