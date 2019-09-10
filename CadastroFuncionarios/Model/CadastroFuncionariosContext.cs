using System;
using System.Data.Entity;
using System.Linq;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CadastroFuncionarios.Model
{
    public class CadastroFuncionariosContext : DbContext
    {
        public CadastroFuncionariosContext() : base("CadastroFuncionariosContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }


        public System.Data.Entity.DbSet<CadastroFuncionarios.Model.Cargo> Cargos { get; set; }

        public System.Data.Entity.DbSet<CadastroFuncionarios.Model.Cidade> Cidades { get; set; }

        public System.Data.Entity.DbSet<CadastroFuncionarios.Model.Departamento> Departamentos { get; set; }

        public System.Data.Entity.DbSet<CadastroFuncionarios.Model.Endereco> Enderecos { get; set; }

        public System.Data.Entity.DbSet<CadastroFuncionarios.Model.Funcionario> Funcionarios { get; set; }

        public System.Data.Entity.DbSet<CadastroFuncionarios.Model.Lotacao> Lotacaos { get; set; }

        public System.Data.Entity.DbSet<CadastroFuncionarios.Model.Pessoa> Pessoas { get; set; }

    }
}
