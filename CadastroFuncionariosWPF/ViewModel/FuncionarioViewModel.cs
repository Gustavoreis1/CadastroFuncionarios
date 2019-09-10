using System;
using CadastroFuncionarios;
using CadastroFuncionarios.Model;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace CadastroFuncionariosWPF.ViewModel
{
    public class FuncionarioViewModel
    {
        public Funcionario.Funcionario Funcionario { get; set; }
        private CadastroFuncionariosContext Context { get; set; }

        public ObservableCollection<Cargo> Cargos {get; set; }

        public FuncionarioViewModel()
        {
           

        }
        
        public void Salvar()
        {
            this.Context.SaveChanges();
        }
    }
}
