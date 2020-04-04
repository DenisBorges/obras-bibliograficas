using ObrasBibliograficas.AppService.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ObrasBibliograficas.AppService.Interface
{
    public interface IAutorAppService
    {
        Task AddAutor(AutorViewModel autor);
        Task<List<AutorViewModel>> GetAllAutors();

        Task ApagarAutor(int id);
    }
}
