using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObrasBibliograficas.Domain
{
    public class AutorModel : Entity
    {

        public string Nome { get; set; }
        public string NomedoMeio { get; set; }
        public string Sobrenome { get; set; }
        public string NomedeAutor { get => FormataNomedeAutor(); }

        public string FormataNomedeAutor()
        {
            var sobreNomes = new string[] { "FILHO", "FILHA", "NETO", "NETA", "SOBRINHO", "SOBRINHA", "JUNIOR" };
            var prefixoSobrenome = new string[] { "da", "de", "do", "das", "dos" };

            try
            {
                var arraySobrenome = Sobrenome.Split(" ").Where(x=> !prefixoSobrenome.Contains(x.ToLower())).ToArray();
                var arrayNomedoMeio = NomedoMeio.Split(" ").Where(x => !prefixoSobrenome.Contains(x.ToLower())).ToArray();


                //CENARIO 1 EX: 1 NOME E 1 SOBRENOME
                if (!arrayNomedoMeio.Any() && arraySobrenome.Length == 1)
                {
                    return $"{Sobrenome.ToUpper()}, {FormataNome(Nome.ToLower())}";

                }
                else if (sobreNomes.Contains(arraySobrenome.Last().ToUpper()))
                {
                    if (arraySobrenome.Length > 1)
                    {
                        return $"{arraySobrenome.Reverse().Skip(1).Take(1).First().ToUpper()} {arraySobrenome.Last().ToUpper()}, {FormataNome(Nome.ToLower())}";
                    }
                    else if (arrayNomedoMeio.Any())
                    {
                        return $"{arrayNomedoMeio.Last().ToUpper()} {arraySobrenome.Last().ToUpper()}, {FormataNome(Nome.ToLower())}";
                    }
                }
                else
                {
                    return $"{arraySobrenome.Last().ToUpper()}, {FormataNome(Nome.ToLower())}";
                }

            }
            catch (Exception ex)
            {
                return "";
            }

            return "";

        }

        private string FormataNome(string nomeLowerCase)
        {
            return char.ToUpper(nomeLowerCase[0]) + nomeLowerCase.Substring(1);
        }

    }
}
