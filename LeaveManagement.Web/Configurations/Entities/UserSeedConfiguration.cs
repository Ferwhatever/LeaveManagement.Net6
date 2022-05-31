using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher=new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "aaccbb00-9b16-464a-a546-49f5c09ce57e",
                    Email = "admin@localhost.com",
                    NormalizedEmail ="ADMIN@LOCALHOST.COM",
                    UserName= "admin@localhost.com",
                    NormalizedUserName= "ADMIN@LOCALHOST.COM",
                    FirstName = "System",
                    LastNames = "Admin",
                    EmailConfirmed=true,
                    PasswordHash=hasher.HashPassword(null,"P@ssw0rd")
                });
        }
    }
}