using System.Windows;

namespace A23_TP1
{
    /// <summary>
    /// Interaction logic for GroupStudentWindow.xaml
    /// </summary>
    public partial class GroupStudentWindow : Window
    {
        private Group Group { get; }
        public Student Student { get; }

        public GroupStudentWindow(Group group, Student student)
        {
            Group = group;
            Student = student;

            InitializeComponent();

            // TODO: Changer le titre de la Window pour le ToString du Group

            // TODO: Mettre à jour la Window avec les information du Student, voir les getters de Group
        }
    }
}
