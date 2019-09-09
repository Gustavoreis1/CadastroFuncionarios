using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncionarios.Model
{
    public class Cargo
    {
        [Key]
        public int IdCargo { get; set; }

        [Required(ErrorMessage = "O campo Nome é requerido!!")]
        [MaxLength(100, ErrorMessage = "O campo Nome recebe no máximo 100 caracteres")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "O campo Salario Base é requerido!!")]
        public Decimal SalarioBase { get; set; }

        [Required(ErrorMessage = "O campo Atribuições é requerido!!")]
        [MaxLength(100, ErrorMessage = "O campo Atribuicões recebe no máximo 200 caracteres")]
        public String Atribuicoes { get; set; }

        public IList<Departamento> Departamentos { get; set; }
        public IList<Lotacao> Lotacaos { get; set; }
    }
}
