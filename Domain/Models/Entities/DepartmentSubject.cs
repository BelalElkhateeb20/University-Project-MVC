using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entities
{
    [Table(name: "departmentSubjects", Schema = "DepSub")]

    public class DepartmentSubject
    {
        [ForeignKey("DepartmentID")]
        public int DepartmentID { get; set; }
        [ForeignKey("SubID")]
        public int SubID { get; set; }
        [InverseProperty("DepartmentSubjects")]
        public virtual Department? Department { get; set; }
        [InverseProperty("DepartmetsSubjects")]
        public virtual Subject? Subject { get; set; }
    }
}
