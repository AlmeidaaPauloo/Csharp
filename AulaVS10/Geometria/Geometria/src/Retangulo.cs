using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria.src;


namespace Geometria.src
{
    public class Retangulo : FormasGeometricas
    {
        public Retangulo(string _nome, double _base, double _altura) : base(_nome, _base, _altura) { }
        public override double CalcularArea()
        {
            double area = Base * Altura;
            return area;
        }
    }
}
