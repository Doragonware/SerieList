using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SeriesList.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SerieList.Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasMany(u => u.UserSeries)
                .WithOne(us => us.User);
        }
    }
}
