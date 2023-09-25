using System.Windows;

namespace A23_TP1
{
    /// <summary>
    /// Interaction logic for AddEvaluationWindow.xaml
    /// </summary>
    public partial class AddEvaluationWindow : Window
    {
        private Group Group { get; }
        private IRefreshableWindow RefreshableWindow { get; }

        public AddEvaluationWindow(Group group, IRefreshableWindow refreshableWindow)
        {
            Group = group;
            RefreshableWindow = refreshableWindow;

            InitializeComponent();

            // TODO: Connecter les événements
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Fermer la Window
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Si l'évaluation est vide, afficher le message suivant
            // MessageBox.ShowMessageBoxError("Evaluation name must not be empty.");


            // TODO: Si le weight est invalide ou plus petit que 0, afficher le message suivant
            // MessageBox.ShowMessageBoxError("Weight must be superior or equal to 0.");

            // var messageBoxResult = MessageBox.ShowMessageBoxQuestion($"Add a new evaluation '{evaluationName}' with weight '{evaluationWeight}'% ?");
            // if (messageBoxResult == MessageBoxResult.Yes)
            {
                // TODO: Générer le prochain id dans App

                // TODO: Créer l'évaluation et l'ajouter au dictionnaire


                RefreshableWindow.Refresh();

                // TODO: Fermer la Window
            }
        }
    }
}
