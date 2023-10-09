using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo7
{
    internal class Rectángulo
    {
       float Base;
       float altura;

        public Rectángulo(float a, float b)
        {
            this.altura = a;
            this.Base = b;
        }

       public float ÁreaDelRectángulo()
        {
             return altura * Base;
        }
    }
}
