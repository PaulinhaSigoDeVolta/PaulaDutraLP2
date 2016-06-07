using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaLp2_07_06_2016
{
    public class Triangulo
    {
        
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }
        public double Lado3 { get; set; }
        public int Id { get; set; }
        public int Posx { get; set; }
        public int Posy { get; set; }

        private int _cor;
        public int Cor {
            get { return _cor; }
            set
            {
                if (Cor >= 0 && Cor <= 16777215)
                    _cor = value;    
            }
        }

        public Triangulo(double a, double b, double c)
        {
            if (Lado1 < (Lado2 + Lado3) && Lado2 < (Lado1 + Lado3) && Lado3 < (Lado2 + Lado1) && Lado1 > 0 && Lado2 > 0 && Lado3 > 0)
            {
                this.Lado1 = a;
                this.Lado2 = b;
                this.Lado3 = c;
            }

        }
    }
}
