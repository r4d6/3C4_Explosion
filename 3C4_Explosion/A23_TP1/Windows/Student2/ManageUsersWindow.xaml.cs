using System.Windows;
using System.Windows.Controls;

namespace A23_TP1
{
    /// <summary>
    /// Interaction logic for ManageUsersWindow.xaml
    /// </summary>
    public partial class ManageUsersWindow : Window, IRefreshableWindow
    {
        // TODO: Retourner les valeurs des ComboBox/ListView
        private UserType SelectedUserType => UserType.All;
        private User? SelectedUser => null;

        public ManageUsersWindow()
        {
            InitializeComponent();

            // TODO: Ajouter les valeurs à la ComboBox

            // TODO: Connecter les événements

            // TODD: Sélectionner une valeur par défaut dans la ComboBox
        }

        public void Refresh()
        {
            // TODO: Mettre à jour la ListView selon le UserType sélectionné

            // TODO: Mettre à jour la ListView selon le contenu de la barre de recherche (chercher Id et noms peu importe la casse)
        }

        private void ComboBoxUserTypes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // TODO: Mettre à jour le titre de la Window

            Refresh();
        }

        private void TextBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }

        private void ListViewUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ButtonDelete.IsEnabled = SelectedUser != null;
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Créer et ouvrir la Window
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Supprimer le User selon son type
        }

        private void DeleteAdmin()
        {
            // TODO: Afficher un message d'erreur
            MessageBox.ShowMessageBoxError($"Cannot delete admin users.");
        }

        private void DeleteStudent()
        {
            // TODO: Vérifier si le User est un Student

            //var messageBoxResultDelete = MessageBox.ShowMessageBoxQuestion($"Delete student {student} ?");
            //if (messageBoxResultDelete != MessageBoxResult.Yes)
            //    return;

            var messageBoxResultConfirmation = MessageBox.ShowMessageBoxStop("Student will be deleted, removed from all Groups and all Evaluations will be deleted.\n\nThis operation cannot be undone.\n\nDo you still want to delete ?");
            if (messageBoxResultConfirmation != MessageBoxResult.Yes)
                return;

            // TODO: Supprimer dans le dictionnaire

            // TODO: Pour chaque Group, supprimer le Student du Group

            // TODO: Pour chaque Evaluation, supprimer les Result du Student

            // TODO: Mettre à jour la ListView et la sélection

            // TODO: Afficher le message
            // MessageBox.ShowMessageBoxInformation($"Student {student} has been deleted, removed from all Groups and all Evaluations gave been deleted.");
        }

        private void DeleteTeacher()
        {
            // TODO: Vérifier si le User est un Teacher


            //var messageBoxResultDelete = MessageBox.ShowMessageBoxQuestion($"Delete teacher {teacher} ?");
            //if (messageBoxResultDelete != MessageBoxResult.Yes)
            //    return;

            var messageBoxResultConfirmation = MessageBox.ShowMessageBoxStop("Teacher will be deleted and removed from all Groups.\n\nThis operation cannot be undone.\n\nDo you still want to delete?");
            if (messageBoxResultConfirmation != MessageBoxResult.Yes)
                return;

            // TODO: Supprimer dans le dictionnaire

            // TODO: Pour chaque Group, mettre le TeacherId à -1

            // TODO: Mettre à jour la ListView et la sélection

            // TODO: Afficher le message
            // MessageBox.ShowMessageBoxInformation($"Teacher {teacher} has been deleted, removed from all Groups and all Evaluations gave been deleted.");
        }
    }
}
