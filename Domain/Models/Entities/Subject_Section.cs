

using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models.Entities
{
    [Table(name: "Subject_Section", Schema = "Sub_sec")]

    public class Subject_Section
    {
        public int SectionId { get; set; }
        public Section Section { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public DayOfWeek Day { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Room { get; set; }
        public string Instructor { get; set; }
    }
}
