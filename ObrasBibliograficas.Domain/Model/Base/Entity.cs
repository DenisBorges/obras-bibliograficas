using System;
using System.Collections.Generic;
using System.Text;

namespace ObrasBibliograficas.Domain
{
    public class Entity
    {
        public int id { get; set; }
        public DateTime? Data_Cadastro { get; set; }
        public DateTime? Data_Atualizacao { get; set; }

    }
}
