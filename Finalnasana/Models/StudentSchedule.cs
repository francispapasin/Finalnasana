using SQLite;
using System;

namespace Finalnasana.Models
{
    public class StudentSchedule
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; } // Unique identifier for each schedule entry

        public string? TaskName { get; set; } // Name of the task or event

        public string? TaskDescription { get; set; } // Description of the task

        public TimeSpan StartTime { get; set; } // Start time of the task

        public TimeSpan EndTime { get; set; } // End time of the task

        public string? DayOfWeek { get; set; } // Day of the week (e.g., "Monday")

        public string? Priority { get; set; } // Priority level (e.g., "High", "Medium", "Low")
    }
}
