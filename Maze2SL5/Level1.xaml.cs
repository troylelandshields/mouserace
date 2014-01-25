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
    public partial class Level1 : Level101
    {
        //CustomCursor customCursor = new CustomCursor();

        public Level1()
        {
            InitializeComponent();
            timer.Text = App.getTime().ToString();
            levelF.setPage(this);
            levelF.getTime();
            prev = "Restart";
            curr = "Level1";
            next = "Level2";
            addLevelNum();
        }

        public override void setValues()
        {
            timer.Text = App.getTime().ToString();
            levelF.setPage(this);
            levelF.getTime();
            prev = "Restart";
            curr = "Level1";
            next = "Level2";
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void CheckBox_Click_1(object sender, RoutedEventArgs e)
        {
            if (checkbox1.IsChecked == true)
            {
                door1.Visibility = Visibility.Collapsed;
            }
            else
            {
                door1.Visibility = Visibility.Visible;
            }
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
