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

namespace ExercicioFormulario
{
    /// <summary>
    /// Lógica interna para MenuPincipal.xaml
    /// </summary>
    public partial class MenuPincipal : Window
    {
        public MenuPincipal()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Cadastrar = new MainWindow();
            Cadastrar.Show();
        }

        private void btnAlterar_Click(object sender, RoutedEventArgs e)
        {
            Alterar A = new Alterar();
            A.Show();
                        
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            Excluir E = new Excluir();
            E.Show();
        }

        private void btnConsultar_Click(object sender, RoutedEventArgs e)
        {
            Consultar C = new Consultar();
            C.Show();
        }
    }
}
