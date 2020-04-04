using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ObrasBibliograficas.AppService.ViewModel
{
    public class AutorViewModel : EntityViewModel
    {
        [Required]
        [StringLength(30, ErrorMessage = "Nome não pode ter mais do que 30 caracteres.")]
        public string Nome { get; set; }

        [StringLength(30, ErrorMessage = "Nome do meio não pode ter mais do que 30 caracteres.")]
        public string NomedoMeio { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Sobrenome não pode ter mais do que 30 caracteres.")]
        public string Sobrenome { get; set; }
        public string NomedeAutor { get; set; }
    }
}
