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
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ExercicioFormulario
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void EnviarCadastro()
        {
            MySqlConnection cmd = new MySqlCommand
            {
                Connection = new MySqlConnetion("Server = localhost; Database = Cadastro; Uid = root; Pwd ="),                
            };

            cmd.Parameters.AddWithValue("@Senha", txtSenha.Text);
            cmd.Parameters.AddWithValue("@Nome", txtNome);
            cmd.Parameters.AddWithValue("@Email", txtEmail);
            cmd.CommandText = "INSERT INTO FormControle (Id, NomeAluno, Relatorio) VALUES (@Id, @NomeAluno, @Relatorio);";
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            MessageBox.Show("Enviado");
        }

        private void btnEviar_Click(object sender, RoutedEventArgs e)
        {
            EnviarCadastro();
        }
        }
    
}
