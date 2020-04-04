using AutoMapper;
using Microsoft.Extensions.Logging;
using ObrasBibliograficas.AppService.Interface;
using ObrasBibliograficas.AppService.ViewModel;
using ObrasBibliograficas.Domain;
using ObrasBibliograficas.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ObrasBibliograficas.AppService
{
    public class AutorAppService : IAutorAppService
    {
        private readonly IMapper _mapper;
        private readonly IAutorRepository _repository;

        public AutorAppService(IMapper mapper, IAutorRepository repository)
        {
            this._mapper = mapper;
            this._repository = repository;
        }

        public async Task AddAutor(AutorViewModel autor)
        {

            await _repository.Salvar(_mapper.Map<AutorModel>(autor));

        }

        public async Task ApagarAutor(int id)
        {
            await _repository.Apagar(id);
        }

        public async Task<List<AutorViewModel>> GetAllAutors()
        {
            return _mapper.Map<List<AutorViewModel>>(await _repository.GetAll());
        }
    }
}
