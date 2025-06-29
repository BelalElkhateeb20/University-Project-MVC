
namespace Domain.Models.Entities
{
    public class Section
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string AcademicYear { get; set; }
        public string Term { get; set; }
        public ICollection<Student_Section> StudentSections { get; set; }
        public ICollection<Subject_Section> SubjectSections { get; set; }
    }
}
