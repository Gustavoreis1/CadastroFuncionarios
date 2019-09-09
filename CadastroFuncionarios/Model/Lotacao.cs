using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncionarios.Model
{
    public class Lotacao
    {
        [Key]
        public int IdLotacao { get; set; }

        [Required(ErrorMessage = "O campo Salario é requerido!!")]
        public decimal Salario { get; set; }

        [Required(ErrorMessage = "O campo Data Inicio é requerido!!")]
        public DateTime Inicio { get; set; }
        
        public DateTime Fim { get; set; }

        [Required(ErrorMessage = "O campo Cargo é requerido!!")]
        public Cargo Cargo { get; set; }

        [Required(ErrorMessage = "O campo Departamento é requerido!!")]
        public Departamento Departamento { get; set; }
    }
}
