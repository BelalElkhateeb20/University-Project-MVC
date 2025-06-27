using Domain.Models.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entities
{
    public class Instructor
    {
        public Instructor()
        {
            Instructors = new HashSet<Instructor>();
            Ins_Subjects = new HashSet<Ins_Subject>();
        }
        [Key]
        public int InsId { get; set; }
        public int UserId { get; set; }
        public string? ENameAr { get; set; }
        public string? ENameEn { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? Position { get; set; }
        public int? SupervisorId { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Salary { get; set; }
        public string? Image { get; set; }

        [ForeignKey(nameof(DepartmentID))]
        public int DepartmentID { get; set; }
        [InverseProperty("Instructors")]
        public Department? Department { get; set; }

        [InverseProperty("Instructor")]
        public Department? DepartmentManager { get; set; }


        [ForeignKey("SupervisorId")]
        [InverseProperty("Instructors")]
        public Instructor? Supervisor { get; set; }

        [InverseProperty("Supervisor")]
        public virtual ICollection<Instructor> Instructors { get; set; }


        [InverseProperty("Instructor")]
        public virtual ICollection<Ins_Subject> Ins_Subjects { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("Instructor")]
        public User User { get; set; }

    }
}

