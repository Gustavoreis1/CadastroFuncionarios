using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroFuncionarios.Model;

namespace CadastroFuncionarios.Model
{
    public class Funcionario : Pessoa
    {
        [Required(ErrorMessage = "O campo Admissão é requerido!!")]
        public DateTime Admissao { get; set; }

        public DateTime Demissao { get; set; }

        public IList<Lotacao> lotacaos { get; set; }

        public class Funcionario
        {
        }
    }
}
