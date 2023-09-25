using System;

namespace A23_TP1
{
    public class Lesson
    {
        public int GroupId { get; init; }

        public DayOfWeek DayOfWeek { get; set; }
        public int PeriodStart { get; set; }
        public int PeriodLength { get; set; }
        public Room Room { get; set; }
    }
}
