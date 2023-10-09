using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo7
{
    internal class Triángulo
    {
        float Base;
        float altura;

        public Triángulo(float Base, float altura)
        {
            this.Base = Base;
            this.altura = altura;
        }

        public float RetornaÁreaTriangular(float Base, float altura)
        {
            return altura*Base/2;
        }
    }
}
