using System;

namespace ScheduleChecker
{
    internal class ScheduleStructure
    {
        public DateTime Date { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int RoomNumber { get; set; }
        public string SubjectName { get; set; }
    }
}