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
    public partial class Level101 : Page
    {
        public static String prev { get; set; }
        public static String next { get; set; }
        public static String curr { get; set; }
        protected Label levelNum = new Label();
        public static Dictionary<String, Level101> levels = new Dictionary<String, Level101>();

        public virtual void addLevelNum()
        {
            levelNum.FontSize = 12;
            levelNum.Content = curr;
        }

        public static void RestartMaze()
        {
            App.Navigate(new Restart());
        }

        public static void PrevLevel()
        {
            if(levels.ContainsKey(prev)){
                string temp = prev;
                levels[temp].setValues();
                App.Navigate(levels[temp]);
            }
            else{
                App.Navigate(getLevel(prev));
            }
        }

        public virtual void setValues()
        {
            prev = "Restart";
            next = "Level1";
            curr = "Restart";
        }

        public static void NextLevel()
        {
            string temp = next;
            if(levels.ContainsKey(temp)){
                levels[temp].setValues();
                App.Navigate(levels[temp]);
            }
            else{
                levels.Add(temp, (Level101)App.Navigate(getLevel(temp)));
            }
        }

        public static void EnterWall(object sender, MouseEventArgs e)
        {
            PrevLevel();
        }

        public static void Up_Click(object sender, RoutedEventArgs e)
        {
            NextLevel();
        }

        public static void EndGame(object sender, RoutedEventArgs e)
        {
            App.End_Click();
        }

        private static Page getLevel(String lvl)
        {
            if(lvl.Equals("Level1"))
            {
                return new Level1();
            }
            else if(lvl.Equals("Level2"))
            {
                return new Level2();
            }
            else if(lvl.Equals("Level3"))
            {
                return new Level3();
            }
            else if(lvl.Equals("Level4"))
            {
                return new Level4();
            }
            else if (lvl.Equals("Level5"))
            {
                return new Level5();
            }
            else if (lvl.Equals("Level6"))
            {
                return new Level6();
            }
            else if (lvl.Equals("Level7"))
            {
                return new Level7();
            }
            else if (lvl.Equals("Level8"))
            {
                return new Level8();
            }
            else if (lvl.Equals("End"))
            {
                return new EndResults();
            }
            else
            {
                return new Restart();
            }
        }

    }
}

