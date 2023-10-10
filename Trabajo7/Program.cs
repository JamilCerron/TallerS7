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
            string respuesta;
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Elija la figura a operar Círculo/Rectángulo/Triángulo");

                string figura = Console.ReadLine();

                switch (figura)
                {
                    case "Triángulo":
                        Console.WriteLine("Escriba la altura");
                        altura = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escriba la base");

                        Base = int.Parse(Console.ReadLine());

                        triángulo = new Triángulo(altura, Base);

                        Console.WriteLine("El área es " + triángulo.RetornaÁreaTriangular());
                        Console.WriteLine("¿Desea escoger otra figura Sí/No?");
                        respuesta = Console.ReadLine();
                        if (respuesta == "No") continuar=false;
                            
                        break;

                    case "Círculo":

                        Console.WriteLine("Escriba la altura");
                        radio = int.Parse(Console.ReadLine());

                        círculo = new Círculo(radio);

                        Console.WriteLine("El área es " + círculo.ÁreaDelCírculo());
                        Console.WriteLine("¿Desea escoger otra figura Sí/No?");
                        respuesta = Console.ReadLine();
                        if (respuesta == "No") continuar = false;

                        break;

                    case "Rectángulo":
                        Console.WriteLine("Escriba la altura");
                        altura = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escriba la base");

                        Base = int.Parse(Console.ReadLine());

                        rectángulo = new Rectángulo(altura, Base);

                        Console.WriteLine("El área es " + rectángulo.ÁreaDelRectángulo());
                        Console.WriteLine("¿Desea escoger otra figura Sí/No?");
                        respuesta = Console.ReadLine();
                        if (respuesta == "No") continuar = false;

                        break;
                }
            }
           
        }
    }
}
