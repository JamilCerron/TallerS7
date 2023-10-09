using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triángulo triángulo;
            Círculo círculo;
            Rectángulo rectángulo;
            float altura;
            float Base;
            float radio;

          
            Console.WriteLine("Elija la figura a operar Círculo/Rectángulo/Triángulo");

            string figura = Console.ReadLine();

            switch (figura)
            {
                case "Triángulo": Console.WriteLine("Escriba la altura");
                    altura = int.Parse(Console.ReadLine());
                    Console.WriteLine("Escriba la base");

                    Base= int.Parse(Console.ReadLine());    

                    triángulo=new Triángulo(altura,Base);

                    Console.WriteLine(triángulo.RetornaÁreaTriangular());
                    break;

                case "Círculo":
                   
                    Console.WriteLine("Escriba la altura");
                    radio= int.Parse(Console.ReadLine());   

                    círculo = new Círculo(radio);

                    Console.WriteLine(círculo.ÁreaDelCírculo());
                    break;

                case "Rectángulo":
                    Console.WriteLine("Escriba la altura");
                    altura = int.Parse(Console.ReadLine());
                    Console.WriteLine("Escriba la base");

                    Base = int.Parse(Console.ReadLine());

                    rectángulo = new Rectángulo(altura, Base);

                    Console.WriteLine(rectángulo.ÁreaDelRectángulo());
                    break;
            }
        }
    }
}
