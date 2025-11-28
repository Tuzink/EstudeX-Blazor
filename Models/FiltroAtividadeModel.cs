using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontendTCC.Models
{
    public class FiltroAtividadesModel
    {
        [Required(ErrorMessage = "Selecione uma matéria ou deixe em branco.")]
        public string MateriaSelecionada { get; set; } = "";
    }
}