using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cadastro.Models
{
    public class Aluno
    {

        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} e obrigatorio!")]
        [StringLength(80, ErrorMessage = "O campo {0} deve conter no minimo {2} e no maximo {1}.", MinimumLength = 4)]
        [Display(Name = "Seu nome")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} e obrigatorio!")]
        [StringLength(80, ErrorMessage = "O campo {0} deve conter no minimo {2} e no maximo {1}.", MinimumLength = 4)]
        [Display(Name = "Seu endereço")]
        public String Endereco { get; set; }

        [Required(ErrorMessage = "O campo {0} e obrigatorio!")]
        [StringLength(14, ErrorMessage = "O campo {0} deve conter no minimo {2} e no maximo {1}.", MinimumLength = 14)]
        [Display(Name = "Seu CPF")]
        public String CPF { get; set; }

        [Required(ErrorMessage = "O campo {0} e obrigatorio!")]
        [StringLength(70, ErrorMessage = "O campo {0} deve conter no minimo {2} e no maximo {1}.", MinimumLength = 5)]
        [Display(Name = "Seu e-mail")]
        public String Email { get; set; }

        [Required(ErrorMessage = "O campo {0} e obrigatorio!")]
        [Display(Name = "Sua data de nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo {0} e obrigatorio!")]
        [StringLength(9, ErrorMessage = "O campo {0} deve conter no minimo {2} e no maximo {1}.", MinimumLength = 1)]
        [Display(Name = "Seu RM")]
        public String RM { get; set; }

        [Required(ErrorMessage = "O campo {0} e obrigatorio!")]
        [StringLength(15, ErrorMessage = "O campo {0} deve conter no minimo {2} e no maximo {1}.", MinimumLength = 14)]
        [Display(Name = "Seu celular")]
        public String Celular { get; set; }

        [Required(ErrorMessage = "O campo {0} e obrigatorio!")]
        public Boolean Ativo { get; set; }

    }
}