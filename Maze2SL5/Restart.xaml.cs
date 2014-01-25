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
    public partial class Restart : Level101
    {

        public Restart()
        {
            InitializeComponent();
            timer.Text = App.getTime().ToString();
            levelF.setPage(this);
            levelF.getTime();
            prev = "Restart";
            next = "Level1";
            curr = "Level0";
            addLevelNum();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            if (App.getTime() == 0)
            {
                App.StartTimer();
            }
            NextLevel();
        }

        public override void addLevelNum()
        {
            base.addLevelNum();
            Thickness thick = new Thickness(219, 331, 0, -23);
            levelNum.Margin = thick;
            this.LayoutRoot2.Children.Add(levelNum);
        }
    }
}
