using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace A23_TP1
{
    /// <summary>
    /// Interaction logic for HomeUserWindow.xaml
    /// </summary>
    public partial class HomeUserWindow : Window
    {
        // TODO: COmpléter les getters
        private Semester SelectedSemester => Semester.All;
        private Group? SelectedGroup => null;

        public HomeUserWindow()
        {
            InitializeComponent();

            // TODO: Mettre à jour la ComboBox

            ListViewGroups.PreviewMouseLeftButtonUp += ListViewGroups_PreviewMouseLeftButtonUp;

            // TODO: Connecter les événements

            // TODO: Sélectionner Semester.All afin de mettre à jour la ListView des Group
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void ComboBoxSemester_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // TODO : Mettre à jour la ListView avec les Groups correspondant au Semester sélectionné
        }

        private void ListViewGroups_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // TODO: Vérifier qu'un Group est sélectionné

            // TODO: Créer et ouvrir la Window de Group selon le User connecté dans App
        }

        private void ButtonChangePassword_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Créer et ouvrir la Window
        }

        private void ButtonResetPassword_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Créer et ouvrir la Window
        }

        private void ButtonLogout_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Se déconnecter dans App
        }
    }
}
