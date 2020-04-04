using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ObrasBibliograficas.Domain;
using ObrasBibliograficas.Domain.Interface;
using Microsoft.EntityFrameworkCore;

namespace ObrasBibliograficas.DataAcess.Repository
{
    public class AutorRepository : IAutorRepository
    {
        protected Conexao Db;
        protected DbSet<AutorModel> DbSet;

        public AutorRepository(Conexao context)
        {
            Db = context;
            DbSet = Db.Set<AutorModel>();
        }

        public async Task Apagar(int id)
        {
            var obj = await this.GetById(id);
            DbSet.Remove(obj);
            await Db.SaveChangesAsync();
        }

        public async Task Atualizar(AutorModel objeto)
        {
            throw new NotImplementedException();
        }

        public async Task<List<AutorModel>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<List<AutorModel>> GetByAutorName(string name, string nomeDoMeio, string sobrenome)
        {
            throw new NotImplementedException();
        }

        public async Task<AutorModel> GetById(int id)
        {
            var obj = await DbSet.FirstAsync(x => x.id == id);

            return obj;
        }

        public async Task Salvar(AutorModel objeto)
        {
            DbSet.Add(objeto);
            await Db.SaveChangesAsync();
        }
    }
}
