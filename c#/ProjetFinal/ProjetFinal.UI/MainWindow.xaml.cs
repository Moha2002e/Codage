using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        private PasswordBox passwordBox;
        private TextBox passwordTextBox;

        public MainWindow()
        {
            InitializeComponent();
            passwordBox = new PasswordBox();
            passwordTextBox = new TextBox();
        }

        private void TogglePassword(object sender, RoutedEventArgs e)
        {
            // Vérifie si le mot de passe est actuellement caché ou visible
        }

        private void NavigateToInscription(object sender, RoutedEventArgs e)
        {
            InscriptionWindow inscriptionWindow = new InscriptionWindow();
            inscriptionWindow.Show();
            this.Close();
        }
    }
}
