using Maze2SL5.ServiceReferenceDB;
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
    public partial class MainPage : UserControl
    {
        Page next = new Restart();
        ServiceDBClient servicedbclient = new ServiceDBClient();
        static List<clsRace> data;

        public MainPage()
        {
            InitializeComponent();
            servicedbclient.getRacesCompleted += new EventHandler<getRacesCompletedEventArgs>(onComplete);
            servicedbclient.getRacesAsync();
        }

        public void onComplete(object sender, ServiceReferenceDB.getRacesCompletedEventArgs e)
        {
            data = e.Result;
            DataGrid1.ItemsSource = data;
        }

        public void onComplete2(object sender, ServiceReferenceDB.getHashRacesCompletedEventArgs e)
        {
            data = e.Result;
            DataGrid1_Copy.ItemsSource = data;
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            App.name = name.Text;
            App.computer = Computer_Copy.SelectedItem.ToString();
            App.os = osBox.SelectedItem.ToString();
            App.mouse = mouseBox.SelectedItem.ToString();
            App.maxlevel = "Level8";
            if (!hashtag_text.Text.Equals("Optional"))
            {
                App.hashgroup = hashtag_text.Text;
            }
            else
            {
                App.hashgroup = "";
            }
            App.Navigate(next);
        }

        private void populateComputer()
        {
            Computer_Copy.Items.Add("Desktop");
            Computer_Copy.Items.Add("Laptop");
        }

        private void populateOSBox()
        {
            osBox.Items.Add("Mac OS");
            osBox.Items.Add("Windows");
            osBox.Items.Add("Other");
        }

        private void populateMouseBox()
        {
            mouseBox.Items.Add("Cheap mouse");
            mouseBox.Items.Add("Expensive mouse");
            mouseBox.Items.Add("Trackball");
            mouseBox.Items.Add("Trackpad");
            mouseBox.Items.Add("Little red dot in middle of keyboard");
        }

        private void Computer_Copy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (osBox.Visibility != Visibility.Visible)
            {
                osBox.Visibility = Visibility.Visible;
                populateOSBox();
            }
        }

        private void osBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (mouseBox.Visibility != Visibility.Visible)
            {
                mouseBox.Visibility = Visibility.Visible;
                populateMouseBox();
            }
        }

        private void mouseBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Start.Visibility = Visibility.Visible;
        }

        private void name_KeyUp(object sender, KeyEventArgs e)
        {
            if (Computer_Copy.Visibility != Visibility.Visible)
            {
                Computer_Copy.Visibility = Visibility.Visible;
                populateComputer();
            }
        }

        private void hashtag_text_GotFocus(object sender, RoutedEventArgs e)
        {
            explanation.Visibility = Visibility.Visible;
            DataGrid1_Copy.Visibility = Visibility.Visible;
            hashtag_text.SelectAll();
        }

        private void hashtag_text_LostFocus(object sender, RoutedEventArgs e)
        {
            explanation.Visibility = Visibility.Collapsed;
        }

        private void hashtag_text_KeyUp(object sender, KeyEventArgs e)
        {
            servicedbclient.getHashRacesCompleted += new EventHandler<getHashRacesCompletedEventArgs>(onComplete2);
            servicedbclient.getHashRacesAsync(hashtag_text.Text.ToString());
        }

        private void name_GotFocus(object sender, RoutedEventArgs e)
        {
            name.SelectAll();
        }
    }
}
