using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo7
{
    internal class Círculo
    {
        private float radio;


        public Círculo(float r) 
        {
            this.radio = r;
        }


        public float ÁreaDelCírculo()
        {
            return 3.14f*radio * radio;
        }
    }

    
}
