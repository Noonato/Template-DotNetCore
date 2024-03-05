using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Entities;

namespace Template.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasData(
                    new User { Id = Guid.Parse("af226a33-cb47-40ab-9910-84d4aa24e5a0"), Name = "User Default", Email = "userdefault@template.com" }
                );
            return builder;
        }
    }
}
