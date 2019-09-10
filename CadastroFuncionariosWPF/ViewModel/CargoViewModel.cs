using System;
using CadastroFuncionarios;
using CadastroFuncionarios.Model;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncionariosWPF.ViewModel
{
    public class CargoViewModel
    {
        private CadastroFuncionariosContext Context { get; set; }

        public void Salvar()
        {
            this.Context.SaveChanges();
        }
    }
}
