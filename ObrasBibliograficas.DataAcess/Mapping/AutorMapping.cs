using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ObrasBibliograficas.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObrasBibliograficas.DataAcess.Mapping
{
    public class AutorMapping : IEntityTypeConfiguration<AutorModel>
    {
        public void Configure(EntityTypeBuilder<AutorModel> builder)
        {
            builder.ToTable("Autor");

            builder.HasKey(x => x.id);

            builder.Property(x => x.id).ValueGeneratedOnAdd().IsRequired();
            builder.Property(x => x.Nome).HasMaxLength(30).IsRequired();
            builder.Property(x => x.NomedoMeio).HasMaxLength(30);
            builder.Property(x => x.Sobrenome).HasMaxLength(30).IsRequired();


        }
    }
}
