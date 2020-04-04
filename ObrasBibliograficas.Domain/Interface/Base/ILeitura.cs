using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ObrasBibliograficas.Domain.Interface
{
    public interface ILeitura<T>
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
    }
}
