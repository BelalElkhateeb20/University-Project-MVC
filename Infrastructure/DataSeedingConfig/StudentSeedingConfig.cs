using Domain.Models.Entities;
using Domain.Models.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.DataSeedingConfig
{
    public class StudentSeedingConfig: IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(
            new Student { StudID = 1, NameEN = "John Smith", NameAR = "جون سميث", Address = "New York", Phone = "1234567890", DepartmentID = 1, UserId = 1,Code="CH1",Email= "john.smith@example.com" ,Image= "John.png",Level="الاولى" },
                new Student { StudID = 2, NameEN = "Ali Ahmed", NameAR = "علي أحمد", Address = "Cairo", Phone = "9876543210", DepartmentID = 1, UserId = 2, Code = "CH2", Email = "ali.ahmed@example.com", Image = "ali.png", Level = "الاولى" },
                new Student { StudID = 3, NameEN = "Sara Kamal", NameAR = "سارة كمال", Address = "Alexandria", Phone = "01112345678", DepartmentID = 1, UserId = 3, Code = "CH3", Email = "sara.kamal@example.com", Image = "sara.png", Level = "الاولى" },
                new Student { StudID = 4, NameEN = "Fatma Adel", NameAR = "فاطمة عادل", Address = "Giza", Phone = "01234567890", DepartmentID = 1, UserId = 4, Code = "CH4", Email = "fatma.adel@example.com", Image = "fatma.png", Level = "الاولى" },
                new Student { StudID = 5, NameEN = "Mohamed Tarek", NameAR = "محمد طارق", Address = "Tanta", Phone = "01098765432", DepartmentID = 1, UserId = 5, Code = "CH5", Email = "mohamed.tarek@example.com", Image = "mohamed.png", Level = "الاولى" }
    );
        }
    }
}
