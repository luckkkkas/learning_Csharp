using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld {
    internal class Retangulo {
        public float Altura;
        public float Largura;

        public float Area() {
            return Largura * Altura;
        }

        public float Perimetro() {
            return (Largura * 2) + (Altura * 2);
        }

        public double Hipotenusa() {
            double catetoA = Math.Pow(Largura,2);
            double catetoC = Math.Pow(Altura, 2);
            double hipotenusa = Math.Sqrt(catetoA + catetoC);
            return hipotenusa;
        }
    }
}
