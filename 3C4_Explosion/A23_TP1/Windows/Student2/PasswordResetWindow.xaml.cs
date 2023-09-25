using System.Windows;

namespace A23_TP1
{
    /// <summary>
    /// Interaction logic for PasswordResetWindow.xaml
    /// </summary>
    public partial class PasswordResetWindow : Window
    {
        public PasswordResetWindow()
        {
            InitializeComponent();

            // TODO: Connecter les événements
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Fermer la Window
        }

        private void ButtonReset_Click(object sender, RoutedEventArgs e)
        {
            var messageBoxResult = MessageBox.ShowMessageBoxQuestion("Reset password, old password will be overwritten ?");
            if (messageBoxResult != MessageBoxResult.Yes)
                return;

            // TODO: Si une information est erronée, afficher le message suivant
            // MessageBox.ShowMessageBoxError("Password reset failed, information provided is incorrect.");

            // TODO: Remettre le password au DefaultPassword

            MessageBox.ShowMessageBoxInformation("Password has been reset.");

            // TODO: Fermer la Window
        }
    }
}
