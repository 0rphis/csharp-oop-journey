using System;
namespace CalculoTriangulo

{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;
        public double CalculoArea ()
        {
            double P = (A + B  + C) / 2.0;
            double raiz = Math.Sqrt (P * ( P - A) * ( P - B) * (P - C));
            return raiz;
        }

    }
}
