using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SeConnecter_Click(object sender, RoutedEventArgs e)
        {
            ConnexionWindow connexion = new ConnexionWindow();
            connexion.Show();
            this.Close();
        }

        private void Inscrire_Click(object sender, RoutedEventArgs e)
        {
            InscrireWindow inscrire = new InscrireWindow();
            inscrire.Show();
            this.Close();
        }
    }
}