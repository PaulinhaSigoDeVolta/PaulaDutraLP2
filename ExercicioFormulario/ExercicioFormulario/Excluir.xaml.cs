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
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ExercicioFormulario
{
    /// <summary>
    /// Interaction logic for Excluir.xaml
    /// </summary>
    public partial class Excluir : Window
    {
        public Excluir()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=LocalHost;DataBase=cadastro;Uid=root;Pwd="),
                CommandText = "DELETE FROM pessoa WHERE Matricula = @matricula"
            };

            cmd.Parameters.AddWithValue("@Matricula", txtMatricula1.Text);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            MessageBox.Show("Excluido !");
            

        }
    }
}
