using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entities
{
    [Table(name: "subjects", Schema = "Sub")]

    public class Subject
    {
        public Subject()
        {
            StudentsSubjects = new HashSet<StudentSubjects>();
            DepartmetsSubjects = new HashSet<DepartmentSubject>();
            Ins_Subjects = new HashSet<Ins_Subject>();
            ExamResults = new HashSet<StudentExamResults>();
        }
        [Key]
        public int SubID { get; set; }
        [StringLength(500)]
        public string? SubjectNameEN { get; set; }
        [StringLength(500)]
        public string? SubjectNameAR { get; set; }
        public int? Period { get; set; }
        [InverseProperty("Subject")]
        public virtual ICollection<StudentSubjects> StudentsSubjects { get; set; }
        [InverseProperty("Subject")]
        public virtual ICollection<DepartmentSubject> DepartmetsSubjects { get; set; }
        [InverseProperty("Subject")]
        public virtual ICollection<Ins_Subject> Ins_Subjects { get; set; }
        [InverseProperty("Subject")]
        public ICollection<StudentExamResults> ExamResults { get; set; }
    }
}
