using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace A23_TP1
{

    /// <summary>
    /// Interaction logic for ManageLessonsWindow.xaml
    /// </summary>
    public partial class ManageLessonsWindow : Window
    {

        private static readonly List<DayOfWeek> ScheduleDaysOfWeek = new()
        {
            DayOfWeek.Monday,
            DayOfWeek.Tuesday,
            DayOfWeek.Wednesday,
            DayOfWeek.Thursday,
            DayOfWeek.Friday,
        };

        private Semester SelectedSemester => ComboBoxSemesters.SelectedItem != null ? (Semester)ComboBoxSemesters.SelectedItem : Semester.All;
        private Room SelectedRoom => ComboBoxRooms.SelectedItem != null ? (Room)ComboBoxRooms.SelectedItem : Room.None;

        private IEnumerable<Group> RoomCourses
        {
            get
            {
                return App.Groups.Values
                    .Where(courseGroups => courseGroups.Semester == SelectedSemester
                        && courseGroups.Lessons.Any(lesson => lesson.Room == SelectedRoom));
            }
        }

        private Dictionary<DayOfWeek, List<string>> PeriodButtonNames { get; } = new Dictionary<DayOfWeek, List<string>>();

        private Lesson? PreviousSelectedLesson { get; set; }

        private DayOfWeek SelectedDayOfWeek { get; set; }
        private int SelectedPeriodLength { get; set; }

        private int PeriodStart;
        private int SelectedPeriodStart
        {
            get => PeriodStart;
            set
            {
                PeriodStart = value;
                ButtonAddLesson.IsEnabled = SelectedPeriodStart != -1;
            }
        }

        public ManageLessonsWindow()
        {
            InitializeComponent();

            ComboBoxSemesters.AddEnumValues<Semester>();
            ComboBoxRooms.AddEnumValues<Room>();

            foreach (var dayOfWeek in ScheduleDaysOfWeek)
            {
                var list = new List<string>();

                for (int i = 0; i < App.Periods.Count; i++)
                {
                    var toggleButtonName = $"{dayOfWeek}{i}Button";
                    list.Add(toggleButtonName);

                    var toggleButton = FindName(toggleButtonName) as ToggleButton;
                    if (toggleButton != null)
                        toggleButton.Click += PeriodButton_Click;
                }

                PeriodButtonNames[dayOfWeek] = list;
            }

            SelectedPeriodStart = -1;
            PreviousSelectedLesson = null;
            ComboBoxRooms.SelectedIndex = 0;

            ButtonAddLesson.Click += ButtonAddLesson_Click;
            ButtonRemoveLesson.Click += ButtonRemoveLesson_Click;
            ComboBoxSemesters.SelectionChanged += ComboBoxSemesters_SelectionChanged;
            ComboBoxRooms.SelectionChanged += ComboBoxRooms_SelectionChanged;

            ComboBoxSemesters.SelectedIndex = 0;
            CourseComboBox.SelectedIndex = 0;
        }

        // TODO: Good luck, vous pouvez remplacer par vos propres fonctions ou utiliser les suivantes

        private void ButtonAddLesson_Click(object sender, RoutedEventArgs e)
        {
        }

        private void ButtonRemoveLesson_Click(object sender, RoutedEventArgs e)
        {
        }

        private void PeriodButton_Click(object sender, RoutedEventArgs e)
        {
        }
        private void ComboBoxSemesters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void ComboBoxRooms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void SwapLessons(DayOfWeek dayOfWeek, int periodStart, Lesson? selectedLesson)
        {
        }

        private void SelectLesson(ToggleButton toggleButton, Lesson selectedLesson)
        {
        }

        private void UpdateLessonSelection(ToggleButton toggleButton, DayOfWeek dayOfWeek, int periodStart)
        {
        }

        private void ResetSelection(ToggleButton toggleButton, DayOfWeek dayOfWeek, int periodStart)
        {
        }

        private void OnRoomChanged()
        {
        }

        private void ResetAllLessons()
        {
        }

        private void ShowAllLessons()
        {
        }
        private ToggleButton? GetToggleButton(DayOfWeek dayOfWeek, int period)
        {
            var toggleButtonName = $"{dayOfWeek}{period}Button";
            var toggleButton = FindName(toggleButtonName) as ToggleButton;
            return toggleButton;
        }

        private static DayOfWeek GetButtonDayOfWeek(string name)
        {
            foreach (var dayOfWeek in ScheduleDaysOfWeek)
            {
                if (name.Contains(dayOfWeek.ToString()))
                    return dayOfWeek;
            }

            return DayOfWeek.Monday;
        }

        public static Color GetRandomColor(string raw)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(raw));
                string hex = BitConverter.ToString(data).Replace("-", string.Empty).Substring(0, 6);
                Color color = (Color)ColorConverter.ConvertFromString("#" + hex);
                return color;
            }
        }
    }
}
