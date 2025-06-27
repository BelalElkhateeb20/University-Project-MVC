using Domain.Models.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Domain.Models.Entities
{
    public class Student
    {
        public Student()
        {
            StudentSubjects = new HashSet<StudentSubjects>();
            ExamResults = new HashSet<StudentExamResults>();
        }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudID { get; set; }
        public int UserId { get; set; }
        [StringLength(200)]
        public string? NameEN { get; set; }
        [StringLength(200)]
        public string? NameAR { get; set; }
        [StringLength(500)]
        public string? Address { get; set; }
        public string Image { get; set; }
        [StringLength(500)]
        public string? Phone { get; set; }
        [ForeignKey("DepartmentID")]
        public int? DepartmentID { get; set; } //can be Null
        public virtual Department? Department { get; set; }

        [InverseProperty("Student")]

        public ICollection<StudentSubjects> StudentSubjects { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("Student")]
        public User User { get; set; }
        [InverseProperty("Student")]
        public ICollection<StudentExamResults> ExamResults { get; set; }
    }
}
