using System.Windows;

namespace A23_TP1
{
    /// <summary>
    /// Interaction logic for AddResultWindow.xaml
    /// </summary>
    public partial class AddResultWindow : Window
    {
        private Evaluation Evaluation { get; }
        private IRefreshableWindow RefreshableWindow { get; }

        // TODO: Compléter les getters
        private Student? SelectedStudent => null;

        public AddResultWindow(Evaluation evaluation, IRefreshableWindow refreshableWindow)
        {
            Evaluation = evaluation;
            RefreshableWindow = refreshableWindow;

            InitializeComponent();

            // TODO: Mettre à jour la ComboBox

            // TODO: Connecter les événements
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Fermer la Window
            Close();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Si aucun Student n'est sélectionné, afficher le message suivant
            // MessageBox.ShowMessageBoxError($"Select a student.");


            // TODO: Si le grade est invalide ou plus petit que 0, afficher le message suivant
            // MessageBox.ShowMessageBoxError("Grade must be superior or equal to 0.");


            // TODO: Si un résultat existe pour l'étudiant, afficher le message suivant

            // var messageBoxResultReplace = MessageBox.ShowMessageBoxQuestion($"Replace grade for student '{student.Id}' from '{previousGrade}' to '{grade}' ?");
            // if (messageBoxResultReplace == MessageBoxResult.Yes)
            {
                // TODO: Écraser le résultat dabs le dictionnaire
                RefreshableWindow.Refresh();

                // TODO: Fermer la Window
            }

            // TODO: Si un résultat n'existe pour l'étudiant, afficher le message suivant
            // var messageBoxResultAdd = MessageBox.ShowMessageBoxQuestion($"Add a new grade for student '{student.Id}' with value '{grade}' ?");
            // if (messageBoxResultAdd == MessageBoxResult.Yes)
            {
                // TODO: Créer un nouveau résultat et l'ajouter au dictionnaire

                RefreshableWindow.Refresh();

                // TODO: Fermer la Window
            }
        }
    }
}
