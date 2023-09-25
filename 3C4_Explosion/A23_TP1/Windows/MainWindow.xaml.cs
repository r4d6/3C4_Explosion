using System.Windows;
using System.Windows.Input;

namespace A23_TP1
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // TODO: Connecter les événements
            ButtonLogin.Click += ButtonLogin_Click;
            ButtonForgotPassword.Click += ButtonForgotPassword_Click;

            // TODO : Remettre le User connecté dans App à null
            App.LoggedInUser = null;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Login();
            }
        }

        private void ButtonForgotPassword_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Créer et afficher la Window
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            Login();
        }

        private void Login()
        {
            // TODO: Si une information n'est pas bonne ou le mauvais type de User est sélectionné, afficher le message suivant
            // Les admins peuvent se connecter peu importe le type de User sélectionné
            MessageBox.ShowMessageBoxError("User not found.\n\nPlease verify Username, Password or user type.");

            // TODO: Ouvrir la Home Window pour les Admins ou pour les autres users
        }
    }
}
