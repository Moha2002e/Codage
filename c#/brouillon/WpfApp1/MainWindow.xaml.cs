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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Logique pour TextBox_TextChanged
        }

        private void EmailTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Logique pour EmailTextBox_TextChanged
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            // Récupérer les valeurs des TextBox
            string name = NameTextBox.Text;
            string email = EmailTextBox.Text;
            string phone = PhoneTextBox.Text;
            string address = AddressTextBox.Text;

            // Afficher les valeurs dans une MessageBox
            MessageBox.Show($"Nom: {name}\nEmail: {email}\nTéléphone: {phone}\nAdresse: {address}", "Informations soumises");
        }
    }
}