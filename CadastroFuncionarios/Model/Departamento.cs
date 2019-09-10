using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroFuncionarios.Model;

namespace CadastroFuncionarios.Model
{
    public class Departamento
    {
        [Key]
        public int IdDepartamento { get; set; }

        [Required(ErrorMessage = "O campo Nome é requerido!!")]
        [MaxLength(100, ErrorMessage = "O campo Nome recebe no máximo 100 caracteres")]
        public String Nome { get; set; }

        public IList<Cargo> Cargos { get; set; }
    }
}
