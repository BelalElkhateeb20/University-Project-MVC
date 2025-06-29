using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entities
{
    [Table(name: "Student_Section", Schema = "Stud_sec")]

    public class Student_Section
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int SectionId { get; set; }
        public Section Section { get; set; }
    }
}
