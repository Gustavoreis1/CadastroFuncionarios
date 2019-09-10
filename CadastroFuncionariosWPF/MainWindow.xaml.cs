using CadastroFuncionariosWPF.Views;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CadastroFuncionariosWPF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FuncionariosMenu_Click(object sender, RoutedEventArgs e)
        {
            Window window = new WindowFuncionario();
            window.ShowDialog();
        }

        private void SairMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
