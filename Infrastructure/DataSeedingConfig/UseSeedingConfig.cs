using Domain.Models.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.DataSeedingConfig
{
    public class UseSeedingConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {


            var users = new List<User>
            {
                new() {
                    Id = 1,
                    UserName = "john.smith",
                    Email = "john.smith@example.com",
                    FullName = "John Smith",
                    Code = "Code1",
                    NormalizedUserName = "JOHN.SMITH",
                    NormalizedEmail = "JOHN.SMITH@EXAMPLE.COM",
                    PasswordHash = "b4Xi+yJjC7uAwW2h7JqHgEPvQNkyukUcCKQJVJV7Hcw=",
                    SecurityStamp = "SEC_STAMP_USER1",
                    ConcurrencyStamp = "CON_STAMP_USER1",
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    RoleType = "Student",
                    Supervisor = false,
                    Address = "123 Main St",
                    Country = "Egypt"
                },
                new User {
                    Id = 2,
                    UserName = "ali.ahmed",
                    Email = "ali.ahmed@example.com",
                    FullName = "Ali Ahmed",
                    Code = "Code2",
                    NormalizedUserName = "ALI.AHMED",
                    NormalizedEmail = "ALI.AHMED@EXAMPLE.COM",
                    PasswordHash = "j/L0kmTWDDI+z8EtdWsfqSJK24rZzsNXh7XcClqdNJY=",
                    SecurityStamp = "SEC_STAMP_USER2",
                    ConcurrencyStamp = "CON_STAMP_USER2",
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    RoleType = "Student",
                    Supervisor = false,
                    Address = "456 Oak Ave",
                    Country = "Egypt"
                },
                new User {
                    Id = 3,
                    UserName = "sara.kamal",
                    Email = "sara.kamal@example.com",
                    FullName = "Sara Kamal",
                    Code = "Code3",
                    NormalizedUserName = "SARA.KAMAL",
                    NormalizedEmail = "SARA.KAMAL@EXAMPLE.COM",
                    PasswordHash = "mzHt/LwX97iHnoLsyO9nUosJ1I7F/54buWUqL0V646M=",
                    SecurityStamp = "SEC_STAMP_USER3",
                    ConcurrencyStamp = "CON_STAMP_USER3",
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    RoleType = "Student",
                    Supervisor = false,
                    Address = "789 Pine Ln",
                    Country = "Egypt"
                },
                new User {
                    Id = 4,
                    UserName = "fatma.adel",
                    Email = "fatma.adel@example.com",
                    FullName = "Fatma Adel",
                    Code = "Code4",
                    NormalizedUserName = "FATMA.ADEL",
                    NormalizedEmail = "FATMA.ADEL@EXAMPLE.COM",
                    PasswordHash = "Mw/DDLpeE+CgfHyyjy5O1lEsx5+UIx0NOw02ZqK2HjY=",
                    SecurityStamp = "SEC_STAMP_USER4",
                    ConcurrencyStamp = "CON_STAMP_USER4",
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    RoleType = "Student",
                    Supervisor = false,
                    Address = "101 Elm St",
                    Country = "Egypt"
                },
                new User {
                    Id = 5,
                    UserName = "mohamed.tarek",
                    Email = "mohamed.tarek@example.com",
                    FullName = "Mohamed Tarek",
                    Code = "Code5",
                    NormalizedUserName = "MOHAMED.TAREK",
                    NormalizedEmail = "MOHAMED.TAREK@EXAMPLE.COM",
                    PasswordHash = "fFvW7rprIKAbYotMRpBQuTG1ix/fX4pnRUjycbWed64=",
                    SecurityStamp = "SEC_STAMP_USER5",
                    ConcurrencyStamp = "CON_STAMP_USER5",
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    RoleType = "Student",
                    Supervisor = false,
                    Address = "202 Birch Ct",
                    Country = "Egypt"
                }
              };
            builder.HasData(users);
        }
    }
}
