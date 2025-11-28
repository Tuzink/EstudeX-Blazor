using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontendTCC.Models
{
    public class AtividadeCriarModel
    {
        [Required(ErrorMessage = "Informe o título da atividade.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Informe a descrição da atividade.")]
        public string Descricao { get; set; }
    }
}