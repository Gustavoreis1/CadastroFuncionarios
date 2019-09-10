using System;
using CadastroFuncionarios;
using CadastroFuncionarios.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace CadastroFuncionariosWPF.ViewModel
{
    public class FuncionarioViewModel
    {
        public ObservableCollection<Cargo> Cargos
        { get; set; }

        public void Salvar()
        {
            this.Context.SaveChanges();
        }
    }
}
