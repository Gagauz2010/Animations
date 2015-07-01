using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Begin_work_with;
using DrawerMenu;
using Update;
using Windows8RightMenu;

namespace AnimationChooser
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Begin_work_with.MainWindow windowBegin;
        DrawerMenu.MainWindow windowDrawer;
        Update.MainWindow windowUpdate;
        Windows8RightMenu.MainWindow windows8Menu;

        public MainWindow()
        {
            InitializeComponent();          
        }

        private void button_start_Click(object sender, RoutedEventArgs e)
        {
            if (windowBegin == null)
            {
                windowBegin = new Begin_work_with.MainWindow();
                windowBegin.Closed += (obj_sender, args) => windowBegin = null;
                windowBegin.Owner = this;
                windowBegin.Show();
            }
            windowBegin.Focus();
        }

        private void button_drawer_Click(object sender, RoutedEventArgs e)
        {
            if (windowDrawer == null)
            {
                windowDrawer = new DrawerMenu.MainWindow();
                windowDrawer.Closed += (obj_sender, args) => windowDrawer = null;
                windowDrawer.Owner = this;
                windowDrawer.Show();
            }
            windowDrawer.Focus();
        }

        private void button_update_Click(object sender, RoutedEventArgs e)
        {
            if (windowUpdate == null)
            {
                windowUpdate = new Update.MainWindow();
                windowUpdate.Closed += (obj_sender, args) => windowUpdate = null;
                windowUpdate.Owner = this; 
                windowUpdate.Show();
            }
            windowUpdate.Focus();
        }

        private void button_menu_Click(object sender, RoutedEventArgs e)
        {
            if (windowUpdate == null)
            {
                windows8Menu = new Windows8RightMenu.MainWindow();
                windows8Menu.Closed += (obj_sender, args) => windows8Menu = null;
                windows8Menu.Owner = this;
                windows8Menu.Show();
            }
            windows8Menu.Focus();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            foreach (Window w in this.OwnedWindows)
                w.Close();
        }
    }
}
