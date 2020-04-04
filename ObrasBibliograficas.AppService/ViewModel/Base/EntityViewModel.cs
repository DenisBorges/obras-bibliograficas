using System;
using System.Collections.Generic;
using System.Text;

namespace ObrasBibliograficas.AppService.ViewModel
{
    public class EntityViewModel
    {
        public int id { get; set; }
        public DateTime? Data_Cadastro { get; set; }
        public DateTime? Data_Atualizacao { get; set; }
    }
}
