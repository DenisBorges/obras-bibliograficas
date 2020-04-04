using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ObrasBibliograficas.DataAcess.Mapping;
using ObrasBibliograficas.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ObrasBibliograficas.DataAcess
{
    public class Conexao :DbContext
    {

        public Conexao(){}

        public Conexao(DbContextOptions<Conexao> options) : base(options)
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
            ChangeTracker.LazyLoadingEnabled = false;
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public  DbSet<AutorModel> Autor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AutorMapping());
            modelBuilder.Entity<AutorModel>().Ignore(t => t.NomedeAutor);

            base.OnModelCreating(modelBuilder);
        }


        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("Data_Cadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("Data_Atualizacao").CurrentValue = DateTime.Now;
                    entry.Property("Data_Cadastro").CurrentValue = DateTime.Now;
                }


                if (entry.State == EntityState.Modified)
                {
                    entry.Property("Data_Cadastro").IsModified = false;
                    entry.Property("Data_Atualizacao").CurrentValue = DateTime.Now;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }



    }
}
