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
    /// Lógica interna para WindowCargo.xaml
    /// </summary>
    public partial class WindowCargo : Window
    {
        public ViewModel.CargoViewModel CargoViewModel { get; set; }
        public WindowCargo()
        {
            InitializeComponent();
        }

        private void SalvarButton_Click(object sender, RoutedEventArgs e)
        {
            private void SalvarButton_Click(object sender, RoutedEventArgs e)
            {
                this.CargoViewModel.Salvar();
                this.Close();
            }
        }

        private void CancelarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
