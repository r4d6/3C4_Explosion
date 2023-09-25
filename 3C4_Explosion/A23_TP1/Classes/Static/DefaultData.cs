using System;
using System.Collections.Generic;

namespace A23_TP1.Classes.Static
{
    static class DefaultData
    {
        public static Dictionary<int, Evaluation> Evaluations = new Dictionary<int, Evaluation>()
        {
            {
                6001,
                new Evaluation()
                {
                    Id = 6001,
                    GroupId = 21001,
                    Name = "Exam 1",
                    Weight = 20,
                    Results = new Dictionary<int, Result>
                    {
                        { 21000123, new Result() { StudentId = 21000123, EvaluationId = 6001, Grade = 15 } },
                        { 21000456, new Result() { StudentId = 21000456, EvaluationId = 6001, Grade = 10 } },
                        { 21000789, new Result() { StudentId = 21000789, EvaluationId = 6001, Grade = 5 } },
                        { 19887766, new Result() { StudentId = 19887766, EvaluationId = 6001, Grade = 5 } },
                        { 19559977, new Result() { StudentId = 19559977, EvaluationId = 6001, Grade = 10 } },
                        { 18996644, new Result() { StudentId = 18996644, EvaluationId = 6001, Grade = 15 } },
                    }
                }
            },
            {
                6002,
                new Evaluation()
                {
                    Id = 6002,
                    GroupId = 21001,
                    Name = "TP 1",
                    Weight = 30,
                    Results = new Dictionary<int, Result>
                    {
                        { 21000123, new Result() { StudentId = 21000123, EvaluationId = 6002, Grade = 25 } },
                        { 21000456, new Result() { StudentId = 21000456, EvaluationId = 6002, Grade = 20 } },
                        { 21000789, new Result() { StudentId = 21000789, EvaluationId = 6002, Grade = 15 } },
                        { 19887766, new Result() { StudentId = 19887766, EvaluationId = 6002, Grade = 15 } },
                        { 19559977, new Result() { StudentId = 19559977, EvaluationId = 6002, Grade = 20 } },
                        { 18996644, new Result() { StudentId = 18996644, EvaluationId = 6002, Grade = 25 } },
                    }
                }
            },
            {
                6003,
                new Evaluation()
                {
                    Id = 6003,
                    GroupId = 21002,
                    Name = "Exam 2",
                    Weight = 30,
                    Results = new Dictionary<int, Result>
                    {
                        { 21000123, new Result() { StudentId = 21000123, EvaluationId = 6003, Grade = 25 } },
                        { 21000456, new Result() { StudentId = 21000456, EvaluationId = 6003, Grade = 20 } },
                        { 21000789, new Result() { StudentId = 21000789, EvaluationId = 6003, Grade = 15 } },
                        { 19887766, new Result() { StudentId = 19887766, EvaluationId = 6003, Grade = 15 } },
                        { 19559977, new Result() { StudentId = 19559977, EvaluationId = 6003, Grade = 20 } },
                        { 18996644, new Result() { StudentId = 18996644, EvaluationId = 6003, Grade = 25 } },
                    }
                }
            },
            {
                6004,
                new Evaluation()
                {
                    Id = 6004,
                    GroupId = 21002,
                    Name = "Exam 1",
                    Weight = 50,
                    Results = new Dictionary<int, Result>
                    {
                        { 21000123, new Result() { StudentId = 21000123, EvaluationId = 6004, Grade = 35 } },
                        { 21000456, new Result() { StudentId = 21000456, EvaluationId = 6004, Grade = 30 } },
                        { 21000789, new Result() { StudentId = 21000789, EvaluationId = 6004, Grade = 25 } },
                        { 19887766, new Result() { StudentId = 19887766, EvaluationId = 6004, Grade = 25 } },
                        { 19559977, new Result() { StudentId = 19559977, EvaluationId = 6004, Grade = 30 } },
                        { 18996644, new Result() { StudentId = 18996644, EvaluationId = 6004, Grade = 25 } },
                    }
                }
            },
            {
                6005,
                new Evaluation()
                {
                    Id = 6005,
                    GroupId = 21002,
                    Name = "Exam 2",
                    Weight = 50,
                    Results = new Dictionary<int, Result>
                    {
                        { 21000123, new Result() { StudentId = 21000123, EvaluationId = 6005, Grade = 45 } },
                        { 21000456, new Result() { StudentId = 21000456, EvaluationId = 6005, Grade = 40 } },
                        { 21000789, new Result() { StudentId = 21000789, EvaluationId = 6005, Grade = 35 } },
                        { 19887766, new Result() { StudentId = 19887766, EvaluationId = 6005, Grade = 35 } },
                        { 19559977, new Result() { StudentId = 19559977, EvaluationId = 6005, Grade = 40 } },
                        { 18996644, new Result() { StudentId = 18996644, EvaluationId = 6005, Grade = 45 } },
                    }
                }
            },
            {
                6006,
                new Evaluation()
                {
                    Id = 6006,
                    GroupId = 21003,
                    Name = "Exam 1",
                    Weight = 50,
                    Results = new Dictionary<int, Result>
                    {
                        { 21000123, new Result() { StudentId = 21000123, EvaluationId = 6006, Grade = 35 } },
                        { 21000456, new Result() { StudentId = 21000456, EvaluationId = 6006, Grade = 30 } },
                        { 21000789, new Result() { StudentId = 21000789, EvaluationId = 6006, Grade = 25 } },
                        { 19887766, new Result() { StudentId = 19887766, EvaluationId = 6006, Grade = 25 } },
                        { 19559977, new Result() { StudentId = 19559977, EvaluationId = 6006, Grade = 30 } },
                        { 18996644, new Result() { StudentId = 18996644, EvaluationId = 6006, Grade = 25 } },
                    }
                }
            },
            {
                6007,
                new Evaluation()
                {
                    Id = 6007,
                    GroupId = 21003,
                    Name = "Exam 2",
                    Weight = 50,
                    Results = new Dictionary<int, Result>
                    {
                        { 21000123, new Result() { StudentId = 21000123, EvaluationId = 6006, Grade = 45 } },
                        { 21000456, new Result() { StudentId = 21000456, EvaluationId = 6006, Grade = 40 } },
                        { 21000789, new Result() { StudentId = 21000789, EvaluationId = 6006, Grade = 35 } },
                        { 19887766, new Result() { StudentId = 19887766, EvaluationId = 6006, Grade = 35 } },
                        { 19559977, new Result() { StudentId = 19559977, EvaluationId = 6006, Grade = 40 } },
                        { 18996644, new Result() { StudentId = 18996644, EvaluationId = 6006, Grade = 45 } },
                    }
                }
            }
        };

        public static Dictionary<int, Group> Groups { get; private set; } = new Dictionary<int, Group>()
        {
            {
                21001,
                new Group()
                {
                    Id = 21001,
                    CourseId = 42010,
                    TeacherId = 1001,
                    Semester = Semester.H20,
                    GroupNumber = 101,
                    StudentIds = new List<int>()
                    {
                        21000123,
                        21000456,
                        21000789,
                        19887766,
                        19559977,
                        18996644,
                    },
                }
            },
            {
                21002,
                new Group()
                {
                    Id = 21002,
                    CourseId = 42030,
                    TeacherId = 1001,
                    Semester = Semester.A21,
                    GroupNumber = 101,
                    StudentIds = new List<int>()
                    {
                        21000123,
                        21000456,
                        21000789,
                        19887766,
                        19559977,
                        18996644,
                    },
                }
            },
            {
                21003,
                new Group()
                {
                    Id = 21003,
                    CourseId = 42030,
                    TeacherId = 1001,
                    Semester = Semester.A21,
                    GroupNumber = 102,
                    StudentIds = new List<int>()
                    {
                        21000123,
                        21000456,
                        21000789,
                        19887766,
                        19559977,
                        18996644,
                    },
                }
            }
        };

        public static Dictionary<int, User> Users { get; private set; } = new Dictionary<int, User>()
        {
            { 1, new Admin() { Id = 0, FirstName = "admin", LastName = "admin", Password = "admin" } },

            { 1001, new Teacher() { Id = 1001, FirstName = "Mael", LastName = "Perreault", Password = "mperreault" } },
            { 1002, new Teacher() { Id = 1002, FirstName = "Yannick", LastName = "Charron", Password = "ycharron" } },
            { 1003, new Teacher() { Id = 1003, FirstName = "Karine", LastName = "Moreau", Password = "kmoreau"  } },
            { 1004, new Teacher() { Id = 1004, FirstName = "Robert", LastName = "Turenne", Password = "rturenne" } },
            { 1005, new Teacher() { Id = 1005, FirstName = "Alain", LastName = "Martel", Password = "amartel" } },

            { 21000123, new Student() { Id = 21000123, FirstName = "Paul", LastName = "Berube", Password = "pberube" } },
            { 21000456, new Student() { Id = 21000456, FirstName = "Mathieu", LastName = "Gagnon", Password = "mgagnon" } },
            { 21000789, new Student() { Id = 21000789, FirstName = "Robert", LastName = "Simard", Password = "rsimard" } },
            { 19887766, new Student() { Id = 19887766, FirstName = "Elise", LastName = "Huard", Password = "ehuard" } },
            { 19559977, new Student() { Id = 19559977, FirstName = "Marie", LastName = "Sauve", Password = "msauve" } },
            { 18996644, new Student() { Id = 18996644, FirstName = "Sylvie", LastName = "Michaud", Password = "smichaud" } },
        };

        public static List<Course> Courses { get; private set; } = new List<Course>()
        {
            new Course()
            {
                Id = 42010,
                Discipline = 420,
                Acronym = "1C5",
                Name = "Ordinateurs et systèmes d'exploitation",
            },
            new Course()
            {
                Id = 42030,
                Discipline = 420,
                Acronym = "3C4",
                Name = "Programmation d'interfaces graphiques",
            },
        };

        public static List<Lesson> Lessons { get; private set; } = new List<Lesson>()
        {
            new Lesson() { GroupId = 21001, DayOfWeek = DayOfWeek.Tuesday, PeriodStart = 7, PeriodLength = 2, Room = Room.D139 },
            new Lesson() { GroupId = 21001, DayOfWeek = DayOfWeek.Thursday, PeriodStart = 0, PeriodLength = 3, Room = Room.D139 },
            new Lesson() { GroupId = 21001, DayOfWeek = DayOfWeek.Monday, PeriodStart = 5, PeriodLength = 2, Room = Room.D134 },
            new Lesson() { GroupId = 21002, DayOfWeek = DayOfWeek.Wednesday, PeriodStart = 2, PeriodLength = 2, Room = Room.D134 },
            new Lesson() { GroupId = 21003, DayOfWeek = DayOfWeek.Monday, PeriodStart = 2, PeriodLength = 2, Room = Room.D136 },
            new Lesson() { GroupId = 21003, DayOfWeek = DayOfWeek.Wednesday, PeriodStart = 9, PeriodLength = 2, Room = Room.D134 },
        };

        public static List<Period> Periods { get; } = new List<Period>()
        {
            new Period() { StartTimeSpan = new TimeSpan(8, 0, 0) },
            new Period() { StartTimeSpan = new TimeSpan(8, 55, 0) },
            new Period() { StartTimeSpan = new TimeSpan(9, 50, 0) },
            new Period() { StartTimeSpan = new TimeSpan(10, 45, 0) },
            new Period() { StartTimeSpan = new TimeSpan(11, 40, 0) },
            new Period() { StartTimeSpan = new TimeSpan(12, 35, 0) },
            new Period() { StartTimeSpan = new TimeSpan(13, 30, 0) },
            new Period() { StartTimeSpan = new TimeSpan(14, 25, 0) },
            new Period() { StartTimeSpan = new TimeSpan(15, 20, 0) },
            new Period() { StartTimeSpan = new TimeSpan(16, 15, 0) },
            new Period() { StartTimeSpan = new TimeSpan(17, 10, 0) },
        };
    }
}
