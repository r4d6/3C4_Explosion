using System.Windows;
using System.Windows.Controls;

namespace A23_TP1
{
    /// <summary>
    /// Interaction logic for GroupTeacherWindow.xaml
    /// </summary>
    public partial class GroupTeacherWindow : Window, IRefreshableWindow
    {
        private Group Group { get; }

        // TODO: Compléter les getter
        private Evaluation? SelectedEvaluation => null
        private Result? SelectedResult => null;

        public GroupTeacherWindow(Group group)
        {
            Group = group;

            InitializeComponent();

            // TODO: Connecter les événements

            // TODO: Mettre à jour le titre de la Window

            Refresh();
        }

        public void Refresh()
        {
            ComboBoxEvaluations.SelectionChanged -= ComboBoxEvaluations_SelectionChanged;

            // TODO: Mettre à jour la ComboBox

            ComboBoxEvaluations.SelectionChanged += ComboBoxEvaluations_SelectionChanged;

            // TODO: Sélectionner le premier élément
        }

        private void ButtonAddResult_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Créer et ouvrir la window
        }

        private void TextBoxEvaluationWeight_TextChanged(object sender, TextChangedEventArgs e)
        {
            // TODO: Vérifier que la valeur entrée est valide et supérieure à 0

            // TODO : Mettre à jour la valeur de l'évaluation

            OnStudentSelected();
        }

        private void ButtonAddEvaluation_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Créer et ouvrir la window
        }

        private void ComboBoxEvaluations_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // TODO: Vérifier qu'une évaluation est sélectionnée

            // TODO: Mettre à jour les informations de l'écran

            ListViewResults.SelectionChanged -= ListViewResults_SelectionChanged;

            // TODO: Mettre à jour la ListView

            ListViewResults.SelectionChanged += ListViewResults_SelectionChanged;

            // TODO: Sélectionner le premier Student dans la ListView
        }

        private void ListViewResults_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // TODO : Vérifier qu'un Result est sélectionné

            // TODO: Mettre à jour la TextBox avec le Id du Student du Result
        }

        private void TextBoxStudentId_TextChanged(object sender, TextChangedEventArgs e)
        {
            OnStudentSelected();
        }

        private void OnStudentSelected()
        {
            // TODO: Si un le Id de Student dans la TextBox existe, mettre à jour les information de l'écran, sinon vider les champs
        }
    }
}
