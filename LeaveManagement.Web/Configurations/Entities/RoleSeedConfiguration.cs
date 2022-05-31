using LeaveManagement.Web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    internal class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {

        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "70ccb959-9b16-464a-a546-49f5c09ce57e",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()

                },
                 new IdentityRole
                 {
                     Id = "50c0c959-9b16-444a-a543-49f5c09ce57e",
                     Name = Roles.User,
                     NormalizedName = Roles.User.ToUpper()

                 }
                );
        }
    }
}