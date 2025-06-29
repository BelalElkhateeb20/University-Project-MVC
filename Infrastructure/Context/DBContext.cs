using Domain.Models.Entities;
using Domain.Models.Identity;
using Infrastructure.DataSeedingConfig;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class DBContext(DbContextOptions<DBContext> options) : IdentityDbContext<User, Role, int, IdentityUserClaim<int>, IdentityUserRole<int>, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Database Seeding
            //modelBuilder.ApplyConfiguration(new DepartmentSeedingConfig());
            modelBuilder.ApplyConfiguration(new StudentSeedingConfig());
            modelBuilder.ApplyConfiguration(new SectionSeedingConfig());
            modelBuilder.ApplyConfiguration(new SubjectSeedingConfig());
            modelBuilder.ApplyConfiguration(new Subject_SectionSeedingConfig());
            modelBuilder.ApplyConfiguration(new UseSeedingConfig());
            #endregion

            #region Relationships
            modelBuilder.Entity<StudentSubjects>()
                .HasKey(x => new { x.SubID, x.StudID });

            modelBuilder.Entity<Ins_Subject>()
                .HasKey(x => new { x.SubId, x.InsId });

            modelBuilder.Entity<DepartmentSubject>()
                .HasKey(x => new { x.SubID, x.DepartmentID });

            modelBuilder.Entity<Instructor>()
                .HasOne(x => x.Supervisor)
                .WithMany(x => x.Instructors)
                .HasForeignKey(x => x.SupervisorId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Department>()
                .HasOne(x => x.Instructor)
                .WithOne(x => x.DepartmentManager)
                .HasForeignKey<Department>(x => x.InsManager)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Student>()
                .HasOne(s => s.User)
                .WithOne(u => u.Student)
                .HasForeignKey<Student>(s => s.UserId);

            modelBuilder.Entity<Instructor>()
                .HasOne(s => s.User)
                .WithOne(u => u.Instructor)
                .HasForeignKey<Instructor>(s => s.UserId);



            modelBuilder.Entity<Student_Section>()
                .HasKey(ss => new { ss.StudentId, ss.SectionId });

            modelBuilder.Entity<Student_Section>()
                .HasOne(ss => ss.Student)
                .WithMany(s => s.StudentSections)
                .HasForeignKey(ss => ss.StudentId);

            modelBuilder.Entity<Student_Section>()
                .HasOne(ss => ss.Section)
                .WithMany(s => s.StudentSections)
                .HasForeignKey(ss => ss.SectionId);

            modelBuilder.Entity<Subject_Section>()
                .HasKey(ss => new { ss.SectionId, ss.SubjectId });

            modelBuilder.Entity<Subject_Section>()
                .HasOne(ss => ss.Section)
                .WithMany(s => s.SubjectSections)
                .HasForeignKey(ss => ss.SectionId);

            modelBuilder.Entity<Subject_Section>()
                .HasOne(ss => ss.Subject)
                .WithMany(s => s.SectionSubjects)
                .HasForeignKey(ss => ss.SubjectId);

            #endregion
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Student> students { get; set; }
        public DbSet<Instructor> instructors { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Subject> subjects { get; set; }
        public DbSet<StudentSubjects> studentSubjects { get; set; }
        public DbSet<DepartmentSubject> departmentSubjects { get; set; }
        public DbSet<StudentExamResults> examResults { get; set; }
        public DbSet<Subject_Section> subject_Sections  { get; set; }
        public DbSet<Student_Section> student_Sections { get; set; }
        public DbSet<Section> Sections { get; set; }
    }
}
