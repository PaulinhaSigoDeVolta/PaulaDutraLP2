using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra para iniciar o jogo:");
            string palavra = Console.ReadLine();
            int aux = 0;
            char[] ast = new char [palavra.Length];

            while(aux < 7)
            {
                Console.WriteLine("Digite uma letra:");
                char letra = char.Parse(Console.ReadLine());
                

                for (int i = 0; i < palavra.Length; i++)
			    {
                    if(letra == palavra[i])
                    {
                        ast[i] = letra;                                                                     
                    }
                    else
                    {
                        ast[i] = '*';
                        aux ++;
                    }                                     
                }

               Console.WriteLine(ast);
            }
        }
    }
}
