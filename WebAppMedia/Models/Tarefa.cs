using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMedia.Models
{
    public class Tarefa
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(255, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 10)]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [DisplayName("Realizado?")]
        public bool Ativo { get; set; }
    }
}
