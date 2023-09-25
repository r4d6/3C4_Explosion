using System.Windows;

namespace A23_TP1
{
    /// <summary>
    /// Interaction logic for AddUserWindow.xaml
    /// </summary>
    public partial class AddUserWindow : Window
    {
        private UserType UserType { get; }
        public IRefreshableWindow RefreshableWindow { get; }

        public AddUserWindow(UserType userType, IRefreshableWindow refreshableWindow)
        {
            UserType = userType;
            RefreshableWindow = refreshableWindow;

            InitializeComponent();

            // TODO: Connecter les événements

            // TODO: Mettre à jour le contenu de la Window selon le type de User
            // TODO: Utiliser les fonctions dans App NextStudentId et NextTeacherId pour générer un id selon le type de User
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Fermer la Window
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Ajouter un nouveau user selon le type de user
        }

        private void AddStudent()
        {

            // TODO: Si le user existe déjà afficher le message suivant
            // MessageBox.ShowMessageBoxError($"Student with id '{id}' already exist.");

            // TODO: Si un des noms est vide afficher le message suivant
            // MessageBox.ShowMessageBoxError("First name and last name must not be empty.");

            // var messageBoxResult = MessageBox.ShowMessageBoxQuestion($"Add new student '{id}' - '{firstName} {lastName}' ?");
            // if (messageBoxResult == MessageBoxResult.Yes)
            {
                // TODO: Créer un nouveau Student et l'ajouter au dictionnaire

                // TODO: Afficher le message
                // MessageBox.ShowMessageBoxInformation($"New student with {id} has been added.");

                RefreshableWindow.Refresh();

                // TODO: Fermer la Window
            }
        }

        private void AddTeacher()
        {

            // TODO: Si le user existe déjà afficher le message suivant
            // MessageBox.ShowMessageBoxError($"Teacher with id '{id}' already exist.");

            // TODO: Si un des noms est vide afficher le message suivant
            // MessageBox.ShowMessageBoxError("First name and last name must not be empty.");

            // var messageBoxResult = MessageBox.ShowMessageBoxQuestion($"Add new teacher '{id}' - '{firstName} {lastName}' ?");
            // if (messageBoxResult == MessageBoxResult.Yes)
            {
                // TODO: Créer un nouveau Teacher et l'ajouter au dictionnaire

                // TODO: Afficher le message
                // MessageBox.ShowMessageBoxInformation($"New teacher with {id} has been added.");

                RefreshableWindow.Refresh();

                // TODO: Fermer la Window
            }
        }
    }
}
