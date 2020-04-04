using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ObrasBibliograficas.Domain.Interface
{
    public interface IAutorRepository : IGravacao<AutorModel>,ILeitura<AutorModel>
    {
        Task<List<AutorModel>> GetByAutorName(string name,string nomeDoMeio ,string sobrenome);
    }

}
