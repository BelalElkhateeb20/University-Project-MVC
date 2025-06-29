using Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.DataSeedingConfig
{
    public class Subject_SectionSeedingConfig : IEntityTypeConfiguration<Subject_Section>
    {
        public void Configure(EntityTypeBuilder<Subject_Section> builder)
        {
            builder.HasData(
    new Subject_Section
    {
        SectionId = 1,
        SubjectId = 1,
        Day = DayOfWeek.Sunday,
        StartTime = new TimeSpan(8, 30, 0),
        EndTime = new TimeSpan(10, 30, 0),
        Room = "Lap107",
        Instructor = "Eng. Ahmed Izzat"
    },
    new Subject_Section
    {
        SectionId = 2,
        SubjectId = 2,
        Day = DayOfWeek.Monday,
        StartTime = new TimeSpan(10, 30, 0),
        EndTime = new TimeSpan(12, 30, 0),
        Room = "Section405",
        Instructor = "Eng. Sara Tarek"
    },
    new Subject_Section
    {
        SectionId = 2,
        SubjectId = 3,
        Day = DayOfWeek.Tuesday,
        StartTime = new TimeSpan(8, 30, 0),
        EndTime = new TimeSpan(10, 30, 0),
        Room = "111",
        Instructor = "Eng. Khaled Ali"
    }
);
        }
    }
}
