using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroFuncionarios.Classes;

namespace CadastroFuncionarios.Model
{
    public class Pessoa
    {
        [Key]
        public int IdPessoa { get; set; }

        [Required(ErrorMessage = "O campo Nome é requerido!!")]
        [MaxLength(100, ErrorMessage = "O campo Nome recebe no máximo 100 caracteres")]
        public String NomeDiretor { get; set; }

        [Required(ErrorMessage = "O campo CPF é requerido!!")]
        [MaxLength(15, ErrorMessage = "O campo CPF recebe no máximo 15 caracteres")]
        public String CPF { get; set; }

        public Endereco Endereco { get; set; }
    }
}
