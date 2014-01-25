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
    public partial class Level8 : Level101
    {
        public Level8()
        {
            InitializeComponent();
            timer.Text = App.getTime().ToString();
            levelF.setPage(this);
            levelF.getTime();
            prev = "Level7";
            next = "End";
            curr = "Level8";
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
            prev = "Level7";
            next = "End";
            curr = "Level8";
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

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(appear_Copy);
        }

        public void makeLabelBlack(Label l){
            l.Background = new SolidColorBrush(Colors.Black);      
        }

        private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(appear_Copy1);
            makeLabelBlack(appear_Copy2);
        }

        private void CheckBox_Checked_3(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(appear_Copy3);
            makeLabelBlack(appear_Copy4);
        }

        private void CheckBox_Checked_4(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(appear_Copy6);
        }

        private void CheckBox_Checked_5(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(appear_Copy5);
        }

        private void CheckBox_Checked_6(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(appear_Copy7);
            makeLabelBlack(appear_Copy9);
        }

        private void CheckBox_Checked_7(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(appear_Copy10);
            makeLabelBlack(appear_Copy11);
        }

        private void CheckBox_Checked_8(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(appear_Copy13);
            makeLabelBlack(appear_Copy14);
        }

        private void CheckBox_Checked_9(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(appear_Copy12);
            makeLabelBlack(appear_Copy15);
        }

        private void CheckBox_Checked_10(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(appear_Copy16);
            makeLabelBlack(appear_Copy17);
        }

        private void CheckBox_Checked_11(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(appear_Copy18);
        }

        private void CheckBox_Checked_12(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(appear_Copy20);
            collapse1.Visibility = Visibility.Collapsed;
            collapse2.Visibility = Visibility.Collapsed;
        }

        private void CheckBox_Checked_13(object sender, RoutedEventArgs e)
        {
            if (collapse1.Visibility == Visibility.Visible)
            {
                makeLabelBlack(collapse1);
            }
        }

        private void CheckBox_Checked_14(object sender, RoutedEventArgs e)
        {
            if (collapse2.Visibility == Visibility.Visible)
            {
                makeLabelBlack(collapse2);
            }
        }

        private void CheckBox_Checked_15(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(appear_Copy21);
            makeLabelBlack(appear_Copy19);
        }

        private void CheckBox_Checked_16(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(appear_Copy21);
            makeLabelBlack(appear_Copy20);
        }

        private void CheckBox_Checked_17(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(appear_Copy1);
            makeLabelBlack(appear_Copy2);
        }

        private void CheckBox_Checked_18(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(collapse2_Copy4);
        }

        private void CheckBox_Checked_19(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(appear_Copy22);
            makeLabelBlack(appear_Copy17);
        }

        private void CheckBox_Checked_20(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(appear_Copy22);
        }

        private void CheckBox_Checked_21(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(appear_Copy24);
            makeLabelBlack(collapse2_Copy2);
        }

        private void CheckBox_Checked_22(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(appear_Copy23);
            makeLabelBlack(collapse2_Copy3);
            makeLabelBlack(appear_Copy25);
        }

        private void CheckBox_Checked_23(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(appear_Copy22);
            makeLabelBlack(collapse2_Copy);
        }

        private void CheckBox_Checked_24(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(collapse2_Copy1);
        }

        private void CheckBox_Checked_25(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(collapse2_Copy1);
        }

        private void CheckBox_Checked_26(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(collapse2_Copy);
            makeLabelBlack(appear_Copy24);
        }

        private void CheckBox_Checked_27(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(collapse2_Copy2);
            makeLabelBlack(appear_Copy23);
        }

        private void CheckBox_Checked_28(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(collapse2_Copy3);
            makeLabelBlack(appear_Copy25);
        }

        private void key1_Checked(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(appear_Copy15x2);
            if (keys())
            {
                label_Copy.Visibility = Visibility.Collapsed;
                label_Copy1.Visibility = Visibility.Collapsed;
                label_Copy2.Visibility = Visibility.Collapsed;             
            }
        }

        private void key2_Checked(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(appear_Copy16);
            makeLabelBlack(appear_Copy15);
            makeLabelBlack(appear_Copy18);
            if (keys())
            {
                label_Copy.Visibility = Visibility.Collapsed;
                label_Copy1.Visibility = Visibility.Collapsed;
                label_Copy2.Visibility = Visibility.Collapsed;
            }
        }

        private void key3_Checked_1(object sender, RoutedEventArgs e)
        {
            if (keys())
            {
                label_Copy.Visibility = Visibility.Collapsed;
                label_Copy1.Visibility = Visibility.Collapsed;
                label_Copy2.Visibility = Visibility.Collapsed;
            }
        }

        private bool keys()
        {
            if ((bool)key1.IsChecked && (bool)key2.IsChecked && (bool)key3.IsChecked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void CheckBox_Checked_29(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(appear_Copy22);
        }

        private void CheckBox_Checked_30(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(appear_Copy26);
            makeLabelBlack(appear_Copyx);
        }

        private void CheckBox_Checked_31(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(appear_Copy27);
            makeLabelBlack(appear_Copy28);
        }

        private void CheckBox_Checked_32(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(appear_Copy27x);
            makeLabelBlack(appear_Copyx2);
            makeLabelBlack(appear_Copy9);
        }

        private void CheckBox_Checked_33(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(appear_Copy15x);
        }

        private void CheckBox_Checked_34(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(appear_Copy15x);
            makeLabelBlack(appear_Copy15x2);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Up_Click(sender, e);
        }

        private void CheckBox_Checked_35(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(appear_Copy8);
        }

        private void CheckBox_Checked_36(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(appear_Copy27);
            makeLabelBlack(appear_Copyx2);
        }

        private void CheckBox_Checked_37(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(appear_Copy26);
        }

        private void CheckBox_Checked_38(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(appear_Copy25);
            makeLabelBlack(appear_Copyx);
        }

        private void CheckBox_Checked_39(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(appear_Copy25);
        }

        private void CheckBox_Checked_40(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(appear_Copy19);
        }

        private void CheckBox_Checked_41(object sender, RoutedEventArgs e)
        {
            collapse1.Visibility = Visibility.Collapsed;
            collapse2.Visibility = Visibility.Collapsed;
        }

        private void CheckBox_Checked_42(object sender, RoutedEventArgs e)
        {
            makeLabelBlack(appear);
        }
    }
}
