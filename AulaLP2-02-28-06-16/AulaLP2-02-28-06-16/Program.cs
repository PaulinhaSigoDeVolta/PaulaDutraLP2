using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaLP2_02_28_06_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux = 0;
            int auy = 0;
            int n = int.Parse(Console.ReadLine());
            List<Ponto> pontos = new List<Ponto>();
            for (int i = 0; i < n; i++)
            {
                Ponto p = new Ponto (int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                pontos.Add(p);
            }
            for (int i = 0; i < n; i++)
            {
                aux += pontos[i].X;
                auy += pontos[i].Y;
            }

            aux /= n;
            auy /= n;
            Console.WriteLine("({0},{1})", aux, auy);

        }
    }
}
