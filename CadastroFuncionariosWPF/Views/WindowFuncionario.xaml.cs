using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CadastroFuncionariosWPF.Views
{
    /// <summary>
    /// Lógica interna para WindowFuncionario.xaml
    /// </summary>
    public partial class WindowFuncionario : Window
    {
        public ViewModel.FuncionarioViewModel FuncionarioViewModel { get; set; }
        public WindowFuncionario()
        {
            InitializeComponent();
            DataContext = this.FuncionarioViewModel;
        }

        private void SalvarButton_Click(object sender, RoutedEventArgs e)
        {
            this.FuncionarioViewModel.Salvar();
            this.Close();
        }

        private void CancelarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
