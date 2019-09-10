using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroFuncionarios.Model;

namespace CadastroFuncionarios.Model
{
    public class Endereco
    {
        [Key]
        public int IdEndereco { get; set; }

        [Required(ErrorMessage = "O campo Logradouro é requerido!!")]
        [MaxLength(50, ErrorMessage = "O campo Logradouro recebe no máximo 50 caracteres")]
        public String Logradouro { get; set; }
        
        [Required(ErrorMessage = "O campo CEP é requerido!!")]
        [MaxLength(10, ErrorMessage = "O campo CEP recebe no máximo 10 caracteres")]
        public String CEP { get; set; }

        [Required(ErrorMessage = "O campo Numero é requerido!!")]
        [MaxLength(10, ErrorMessage = "O campo Numero recebe no máximo 10 caracteres")]
        public String Numero { get; set; }

        [Required(ErrorMessage = "O campo Complemento é requerido!!")]
        [MaxLength(100, ErrorMessage = "O campo Complemento recebe no máximo 100 caracteres")]
        public String Complemento { get; set; }

        [Required(ErrorMessage = "O campo Cidade é requerido!!")]
        public Cidade Cidade { get; set; }
    }
}
