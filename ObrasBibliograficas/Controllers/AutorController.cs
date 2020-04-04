using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ObrasBibliograficas.AppService.Interface;
using ObrasBibliograficas.AppService.ViewModel;

namespace ObrasBibliograficas.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AutorController : ControllerBase
    {
        private readonly ILogger<AutorController> _log;
        private readonly IAutorAppService _autorService;
        public AutorController(IAutorAppService autorService, ILogger<AutorController> log)
        {
            this._autorService = autorService;
            this._log = log;
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarAutor(AutorViewModel autor)
        {

            try
            {
                await _autorService.AddAutor(autor);

            }
            catch (Exception ex)
            {
                _log.LogError(ex.Message, ex);
                return BadRequest("Houve um erro durante o cadastro do Autor");
            }

            return Ok();

        }


        [HttpGet]
        public async Task<IActionResult> GetAllAuthors()
        {
            try
            {
                var list = await _autorService.GetAllAutors();

                return Ok(list);

            }
            catch (Exception ex)
            {
                _log.LogError(ex.Message, ex);
                return BadRequest("Houve um erro durante a listagem de Autores");
            }


        }

        [HttpDelete]
        public async Task<IActionResult> ApagarAutor(int id)
        {

            try
            {
                await _autorService.ApagarAutor(id);

                return Ok();

            }
            catch (Exception ex)
            {
                _log.LogError(ex.Message, ex);
                return BadRequest("Houve um erro na tentativa de exclusão do Autor. Tente novamente");
            }
        }

    }
}