using System.Windows;

namespace WpfApp1
{
    public partial class InscrireWindow : Window
    {
        public InscrireWindow()
        {
            InitializeComponent();
        }
        private void Main_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
