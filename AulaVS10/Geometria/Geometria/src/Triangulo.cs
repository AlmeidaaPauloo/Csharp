using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria.src
{
    public class Triangulo : FormasGeometricas
    {
        public Triangulo(string _nome, double _base, double _altura) : base(_nome, _base, _altura) { }
        public override double CalcularArea()
        {
            double area = Base * Altura / 2;
            return area;
        }
    }
}
    

