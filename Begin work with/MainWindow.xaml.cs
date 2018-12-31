using System.Windows;

namespace Begin_work_with
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void glow_button_chooser_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            glow_button_start.IsEnabled = true;
        }
    }
}
