using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncionarios.Classes
{
    public class Cidade
    {
        [Key]
        public int IdCidade { get; set; }

        [Required(ErrorMessage = "O campo Nome é requerido!!")]
        [MaxLength(50, ErrorMessage = "O campo Nome recebe no máximo 50 caracteres")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "O campo Estado é requerido!!")]
        [MaxLength(50, ErrorMessage = "O campo Estado recebe no máximo 50 caracteres")]
        public String Estado { get; set; }
    }
}
