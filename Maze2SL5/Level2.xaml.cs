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
    public partial class Level2 : Level101
    {

        public Level2()
        {
            InitializeComponent();
            timer.Text = App.getTime().ToString();
            levelF.setPage(this);
            levelF.getTime();
            prev = "Level1";
            next = "Level3";
            curr = "Level2";
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
            prev = "Level1";
            next = "Level3";
            curr = "Level2";
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

        public override void addLevelNum()
        {
            base.addLevelNum();
            //levelNum.SetValue(Canvas.LeftProperty, 200.0);
            //levelNum.SetValue(Canvas.TopProperty, 100.0);
            Thickness thick = new Thickness(219, 331, 0, -23);
            levelNum.Margin = thick;
            this.LayoutRoot.Children.Add(levelNum);
        }

        #endregion

    }
}
