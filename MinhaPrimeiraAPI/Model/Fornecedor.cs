using System;
using System.ComponentModel.DataAnnotations;

namespace MinhaPrimeiraAPI.Model
{
    public class Fornecedor
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage ="O Campo {0} é Obrigatório")]
        [StringLength(100,ErrorMessage ="O Campo {0} Precisa Ter Entre {2} e {1} Caracteres",MinimumLength = 2)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O Campo {0} é Obrigatório")]
        [StringLength(14,ErrorMessage = "O Campo {0} Precisa Ter Entre {2} e {1} Caracteres",MinimumLength = 11)]
        public string Documento { get; set; }
        public int TipoFornecedor { get; set; }
        public bool Ativo { get; set; }
    }
}
