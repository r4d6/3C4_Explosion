using A23_TP1.Classes;
using A23_TP1.Classes.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace A23_TP1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static int GetNextAvailableId<T>(Dictionary<int, T> dictionary) => dictionary.Keys.Max() + 1;

        public static User? LoggedInUser { get; set; }

        public static Dictionary<int, Evaluation> Evaluations { get; } = DefaultData.Evaluations;
        public static Dictionary<int, Group> Groups { get; } = DefaultData.Groups;
        public static Dictionary<int, User> Users { get; } = DefaultData.Users;

        public static List<Course> Courses { get; } = DefaultData.Courses;
        public static List<Lesson> Lessons { get; } = DefaultData.Lessons;
        public static List<Period> Periods { get; } = DefaultData.Periods;

        // TODO: Compléter les getters
        public static IEnumerable<Admin> Admins => Users.Values.OfType<Admin>();
        public static IEnumerable<Student> Students => Users.Values.OfType<Student>();
        public static IEnumerable<Teacher> Teachers => Users.Values.OfType<Teacher>();

        // TODO: Chercher le prochain id de Student libre débutant avec l'année courante (ex: 23000001 pour 2023), sinon retourner 23000001
        public static int NextStudentId
        {
            get
            {
                var minId = (DateTime.Now.Year - 2000) * 1000000;
                var maxId = (DateTime.Now.Year - 2000 + 1) * 1000000;

                var largestStudentId = Students
                    .Where(student => student.Id > minId && student.Id < maxId)
                    .Max(student => student.Id);

                if (largestStudentId > 0)
                    return largestStudentId + 1;

                return minId + 1;
            }
        }

        // TODO: Chercher le prochain id de Teacher libre parmi les Teachers seulement en débutant à 1001, sinon retourner 10001
        public static int NextTeacherId => Users.Count > 0
                        ? Teachers.Max(teacher => teacher.Id)
                        : 1001;

        public App()
        {
            // TODO: Charger tous les données des fichiers
            LoadAllFiles();
        }

        public static void LoadAllFiles()
        {
            // TODO: À l'aide du FileManager et du DefaultData, charger tous les fichiers dans les structures de données de App
            FileManager.ReadFromFileOrDefault(FileManager.FileName.Evaluations, Evaluations, DefaultData.Evaluations);
            FileManager.ReadFromFileOrDefault(FileManager.FileName.Groups, Groups, DefaultData.Groups);
            FileManager.ReadFromFileOrDefault(FileManager.FileName.Users, Users, DefaultData.Users);

            FileManager.ReadFromFileOrDefault(FileManager.FileName.Courses, Courses, DefaultData.Courses);
            FileManager.ReadFromFileOrDefault(FileManager.FileName.Lessons, Lessons, DefaultData.Lessons);
            FileManager.ReadFromFileOrDefault(FileManager.FileName.Periods, Periods, DefaultData.Periods);
        }

        public static void SaveAllFiles()
        {
            // TODO : À l'aide du FileManager enregistrer tous les fichiers pour toutes les structures de données de App
            FileManager.WriteFile(FileManager.FileName.Evaluations, Evaluations);
            FileManager.WriteFile(FileManager.FileName.Groups, Groups);
            FileManager.WriteFile(FileManager.FileName.Users, Users);

            FileManager.WriteFile(FileManager.FileName.Courses, Courses);
            FileManager.WriteFile(FileManager.FileName.Lessons, Lessons);
            FileManager.WriteFile(FileManager.FileName.Periods, Periods);
        }

        public static void Logout()
        {
            // TODO: Enregistrer tous les fichiers si l'utilisateur accepte, afficher le message suivant
            var messageResult = MessageBox.ShowMessageBoxQuestion("Do you want to save all changes to files ?");
            if (messageResult == MessageBoxResult.Yes)
            {
                SaveAllFiles();
                MessageBox.ShowMessageBoxInformation("Saved changes to all files.");
            }

            // TODO: Afficher la MainWindow
            var window = new MainWindow();
            window.Show();

            // Ferme toutes les autres Window, doit être fait après la rouverture de la MainWindow
            for (int i = Current.Windows.Count - 1; i >= 0; i--)
            {
                if (Current.Windows[i] != window)
                    Current.Windows[i].Close();
            }
        }
    }
}
