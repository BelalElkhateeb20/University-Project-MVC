

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models.Entities
{
    public class StudentExamResults
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int StudentId { get; set; }
        [ForeignKey(nameof(StudentId))]
        public Student Student { get; set; }
        [Required]
        public int SubjectId { get; set; }
        [ForeignKey(nameof(SubjectId))]
        public Subject Subject { get; set; }
        [Required]
        [MaxLength(50)]
        public string ExamName { get; set; }
        public double Degree { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        public DateTime Date { get; set; }
    }
}
