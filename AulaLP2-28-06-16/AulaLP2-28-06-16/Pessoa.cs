using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaLP2_28_06_16
{
    //Classe
    class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set;}
        public string Cpf { get; set; }
        public string TelCel { get; set; }
        public int DiaNasc { get; set; }
        public int MesNasc { get; set; }
        public int AnoNasc { get; set; }

        //Método Construtor
        public Pessoa()
        {

        }
        public Pessoa(string Nome, string Sobrenome)
        {

        }
        public Pessoa (string Cpf)
        {

        }
    }
}
