using data_access.data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.data.Configs
{
    public class EditionEntityConfigs : IEntityTypeConfiguration<Edition>
    {
        public void Configure(EntityTypeBuilder<Edition> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Editions");

            builder
                .HasOne(x => x.Category).WithMany(x => x.Editions).HasForeignKey(x => x.CategoryId);
            builder
                .Property(x => x.CategoryId).HasDefaultValue((int)GamesCategories.Others);
        }
    }
}
