using Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.DataSeedingConfig
{
    public class SectionSeedingConfig : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder)
        {
            builder.HasData(
    new Section
    {
        Id = 1,
        Name = "Group 1",
        AcademicYear = "2024/2025",
        Term = "First"
    },
    new Section
    {
        Id = 2,
        Name = "Group 2",
        AcademicYear = "2024/2025",
        Term = "First"
    },
    new Section
    {
        Id = 3,
        Name = "Group 3",
        AcademicYear = "2024/2025",
        Term = "First"
    }
);
        }
    }
}
