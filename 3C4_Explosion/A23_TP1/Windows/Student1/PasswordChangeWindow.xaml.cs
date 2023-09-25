using System.Windows;

namespace A23_TP1
{
    /// <summary>
    /// Interaction logic for PasswordChangeWindow.xaml
    /// </summary>
    public partial class PasswordChangeWindow : Window
    {
        public PasswordChangeWindow()
        {
            InitializeComponent();

            // TODO: Connecter les événements
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Fermer la Window
        }

        private void ReserButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Vérifier dans App qu'un User est connecté

            // TODO: Si un password est vide afficher le message suivant
            // MessageBox.ShowMessageBoxError("Passwords cannot be empty.");

            var messageBoxResult = MessageBox.ShowMessageBoxQuestion("Change password, old password will be overwritten ?");
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                // TODO: Si l'ancien password n'est pas le bon, afficher le message suivant
                // MessageBox.ShowMessageBoxError("Old password is incorrect.");

                // TODO: Si le password de confirmation n'est pas le même que le nouveau password, afficher le message suivant
                // MessageBox.ShowMessageBoxError("New password and confirmation must be identical.");


                // TODO: Metter à jour le password

                MessageBox.ShowMessageBoxInformation("Password has been changed.");

                // TODO: Fermer la Window
            }
        }
    }
}
