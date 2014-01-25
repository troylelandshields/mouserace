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
    public partial class EndGameDialog : ChildWindow
    {
        int time;

        public EndGameDialog(int time)
        {
            InitializeComponent();
            this.time = time;
            congratsText.Content = "Congratulations! You escaped the \n dungeon in " + time + " seconds!";
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}

