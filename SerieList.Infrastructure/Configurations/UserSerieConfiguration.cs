using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SeriesList.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SerieList.Infrastructure.Configurations
{
    public class UserSerieConfiguration : IEntityTypeConfiguration<UserSerie>
    {
        public void Configure(EntityTypeBuilder<UserSerie> builder)
        {
            builder.Property(us => us.SerieId)
                .IsRequired();
        }
    }
}
