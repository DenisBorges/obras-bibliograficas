using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ObrasBibliograficas.Domain.Interface
{
    public interface IGravacao<T>
    {
        Task Salvar(T objeto);

        Task Atualizar(T objeto);

        Task Apagar(int id);

    }
}
