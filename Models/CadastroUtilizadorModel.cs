using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontendTCC.Models
{
    public class CadastroUtilizadorModel
    {
        [Required(ErrorMessage = "Selecione o tipo de utilizador.")]
        public string TipoUtilizador {get; set;}

        [Required(ErrorMessage = "Escreva seu nome.")]
        public string Nome {get; set;}

        [Required(ErrorMessage = "Porfavor informe seu CPF.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Porfavor informe seu estado(UF).")]
        public string UF { get; set; }

        [Required(ErrorMessage = "Porfavor informe sua cidade.")]
        public string Cidade { get; set; }
    }
}